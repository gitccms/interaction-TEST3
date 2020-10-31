using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using System.Collections;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TEST3
{
    public partial class Form1 : Form
    {
        string ID, name, year_old, salary, line_mess;
        String[] slims = new string[1000];
        int snum = 0;
        int[] widths = { 40, 15, 10, 25 };//listview的列宽

        //MySql相关
        bool sql_flag=false;
        string passwd = null;
        MySqlConnection mycon = null;
        string constr = "server=yocen.top;User Id=iauser;Database=interaction;";
        
        private void stafftextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                writebutton_Click(sender, e);
            }
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            //read_mess();
            //listView1.Clear();
            if (!sql_flag)
            {
                MessageBox.Show("数据库尚未链接！请先输入密码进行连接");
            }

            read_from_mysql();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_sql()
        {
            try
            {
                mycon = new MySqlConnection(constr);
                mycon.Open();
                mycon.Close();
                sql_flag = true;
                MessageBox.Show("云数据库连接成功!");
                writebutton.Enabled = true;
                readbutton.Enabled = true;
                IDtextBox.Enabled = true;
                nametextBox.Enabled = true;
                salarytextBox.Enabled = true;
                yeartextBox.Enabled = true;
                clearbutton.Enabled = true;
            }
            catch (MySqlException ex)
            {
                mycon.Close();
                MessageBox.Show("数据库连接错误："+ex.GetBaseException().ToString());
            }                
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = listView1.Width / 100 * widths[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized ;
            DialogResult dr=MessageBox.Show("请先输入密码登录后再行使用！", "     提示", MessageBoxButtons.YesNo);
            if(dr == DialogResult.No)
            {
                this.Close();
            }
            passwdtextBox.Focus();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            passwd = passwdtextBox.Text;
            constr = ("server = yocen.top; User Id = iauser; Database = interaction; password=" + passwd);
            connect_sql();
        }

        private void passwdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                loginbutton_Click(sender, e);
            }
        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "" || nametextBox.Text == "" || yeartextBox.Text == "" || salarytextBox.Text == "")
            {
                MessageBox.Show("请将信息补充完整后再行录入","信息格式错误",MessageBoxButtons.OKCancel); 
                return;
            }
            ID = IDtextBox.Text;
            name = nametextBox.Text;
            year_old = yeartextBox.Text;
            salary = salarytextBox.Text;
            line_mess = ID + "\",\""+name+"\",\""+year_old+"\",\""+salary;
            if (!sql_flag)
            {
                MessageBox.Show("数据库尚未连接!");
                return;
            }
            write_to_sql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            nametextBox.Clear();
            yeartextBox.Clear();
            salarytextBox.Clear();
        }

        private void write_mess(string lm)
        {
            StreamWriter sw = new StreamWriter("软工18学号.txt", true,Encoding.Default);
            sw.WriteLine(lm);
            sw.Close();
            MessageBox.Show("写入信息成功！");
        }

        private void read_mess()
        {
            StreamReader sr = new StreamReader("软工18学号.csv", Encoding.Default);
            while (true)
            {
                slims[snum++] = sr.ReadLine();
                if (slims[snum-1] == null)
                {
                    snum--;
                    return;
                }
                string[] person = slims[snum - 1].Split(',');
                ListViewItem listem = new ListViewItem(person);
                listView1.Items.Add(listem);
                //MessageBox.Show(slims[snum-1]);
            }
            sr.Close();
        }
        private void read_from_mysql()
        {
            /*listView1.Clear();
            string[] ths = { "工号", "姓名", "年龄", "薪水" };
            for( int i=0;i<ths.Length;i++)
            {
                listView1.Columns.Add(ths[i]);
                listView1.Columns[i].Width = listView1.Width/100 * widths[i];
            }*/
            try
            {
                mycon.Open();
                MySqlCommand cmd = new MySqlCommand("select * from test3;", mycon);

                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string[] person = { reader.GetString("stu_id") , reader.GetString("stu_name") , reader.GetString("age") , reader.GetString("salary") };
                    ListViewItem listem = new ListViewItem(person);
                    listView1.Items.Add(listem);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(),"数据连接错误");
                //throw;
            }
            finally
            {
                mycon.Close();
            }
           
        }
        private void write_to_sql()
        {
            try
            {
                mycon.Open();
                MySqlCommand cmd = new MySqlCommand("insert test3 values(\""+line_mess+"\");", mycon);
                MySqlDataAdapter writer = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("写入成功！");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
                //throw;
            }
            finally
            {
                mycon.Close();
            }
        }
        
        private void change_listview(object sender, EventArgs e)
        {
            if(smallradioButton.Checked)
            {
                listView1.View = View.SmallIcon;
            }
            else
            {
                if(bigradioButton.Checked)
                {
                    listView1.View = View.LargeIcon;
                }
                else
                {
                    listView1.View = View.Details;
                }
            }
        }
    }
}
