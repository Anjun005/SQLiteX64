using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SQLite操作
{
    public partial class Form1 : Form
    {
        string strPath; // = "Data Source=" +Application.StartupPath  + "\\"+"lite3.db";
        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath);
            strPath = "Data Source=" + info.Parent.Parent.Parent.FullName + @"\DB\lite3.db";
            //strPath = 
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(strPath);
            conn.Open();

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            List<userInfo> userInfo = new List<userInfo>();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select * FROM User";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    userInfo a = new userInfo();
                    a.AutoID = reader[0].ToString();
                    a.userName = reader[1].ToString();
                    a.userPasswd = reader[2].ToString();                   
                    a.userRegion = reader[3].ToString();
                    a.Permissions = reader[4].ToString();
                    userInfo.Add(a);

                }
            }
            reader.Close();
            dataGridView1.DataSource = userInfo;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string strPW = textBox1.Text;
            //cmd.CommandText = "UPDATE User SET userPasswd =  " + strPW + "  WHERE userName='Anjun'";
            cmd.CommandText = "UPDATE User SET userPasswd =  '" + strPW + "'  WHERE userName='Anjun'";
            cmd.ExecuteNonQuery();
        }

        //private void BtnInsert_Click(object sender, EventArgs e)
        //{
        //    //SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqliteAAA;Version=3;");
        //    //conn.Open();
        //    string query = "insert into User (AutoID,userName,userPasswd,userRegion,Permissions) values('10','小明','Niu','C6','')";
        //    SQLiteCommand cmd = new SQLiteCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    //conn.Close();
        //    cmd.Dispose();
        //}

        private void BtnInsertS2_Click(object sender, EventArgs e)
        {
            string query= "insert into User (AutoID,userName,userPasswd,userRegion,Permissions) values('"+tBoxAutoID.Text+ "', '" + tBoxName.Text + "', '" + tBoxPW.Text + "', '" + tBoxRegion.Text + "', '" + tBoxPermission.Text + "')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM User WHERE AutoID = 7";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        #region MyRegion
        //1.大量数据频繁Insert特别慢怎么办?
        //解决办法是使用事务来Insert数据.
        //SQLite给出的解释是:正常执行Insert, 每一次执行都占用一次IO, 而使用事务执行, 直到Insert结束只占用一次IO;
        //执行事务Insert代码 
        //https://www.jb51.net/article/122351.htm
        #endregion
        private bool QueryTran(List<string> queryList)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=DataBase;Version=3;");
            SQLiteCommand cmd = conn.CreateCommand();
            conn.Open();
            SQLiteTransaction tran = conn.BeginTransaction();
            bool check = false;
            try
            {
                foreach (string item in queryList)
                {
                    cmd.CommandText = item;
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
                check = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                check = false;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return check;
        }

        private void BtnSelect2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "select * from table1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("Database.sqliteAAA");
        }

        private void BtnOperate_Click(object sender, EventArgs e)
        {
            //创建连接字符串
            SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqliteAAA;Version=3;");
            //这是数据库登录密码
            //conn.SetPassword("1234");//64位的暂时不支持设置密码
            //打开数据库
            conn.Open();
            string query = "create table table1 (id INTEGER, name VARCHAR)";
            //创建命令
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            //执行命令
            cmd.ExecuteNonQuery();
            //释放资源
            conn.Close();
        }

        private void BtnInsert2_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqliteAAA;Version=3;");
            conn.Open();
            string query = "insert into table1 (id,name) values(1,'小明')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Database.sqliteAAA;Version=3;"))
            {
                conn.Open();
                string query = "select * from table1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource  = dt;
            }
        }


    }

    public class userInfo
    {
        public string AutoID { get; set; }
        public string userName { get; set; }
        public string userPasswd { get; set; }
        public string userRegion { get; set; }
        public string Permissions { get; set; }
    }
}
