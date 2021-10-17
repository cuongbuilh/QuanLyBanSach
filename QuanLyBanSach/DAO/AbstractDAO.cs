using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.DAO
{
    abstract class AbstractDAO
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable data;
        public SqlDataAdapter adapter;

        public void KetNoi_Dulieu()
        {
            string strKetNoi =
                @"Data Source=101.96.66.219,8013;Initial Catalog=QLSach;Persist Security Info=True;User ID=sa;Password=Admin1234";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }


        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            adapter = new SqlDataAdapter(Sql, cnn);
            data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}