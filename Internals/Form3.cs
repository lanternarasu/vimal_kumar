using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internals
{
    /*public abstract class students
    {
        int regno;
        string name, course, year, sname;

        public abstract void calculate();
    }

    public class pginternals : students
    {
        int intmarks, tavg, t1, t2 ;
        int ass, atd;
        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }*/
    public partial class pg : Form
    {
        SqlConnection conn = new SqlConnection("data source = WT04; initial catalog=marks ;integrated security = SSPI");
        public pg()
        {
            InitializeComponent();
        }

        private void pg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from pginternals WHERE regno = '" + textBox1.Text + "'", conn);
            conn.Open();
            DataTable t = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            a.Fill(t);
            dataGridView1.DataSource = t;
            MessageBox.Show("Imported Successfully");
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
