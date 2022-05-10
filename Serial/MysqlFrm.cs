using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial
{
    public partial class MysqlFrm : Form
    {
        public MysqlFrm()
        {
            InitializeComponent();
            QueryToDataGrip();
        }

        public void QueryToDataGrip()
        {
            string sqlStr = "select * from thw_datas";
            DataSet ds = MySQLHelper.Query(sqlStr);
            if (ds!=null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
