using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLSinhVienLab12.DAL
{
    public class KetQuaDAL
    {
        public DataTable GetLop()
        {
            using SqlConnection conn = new SqlConnection(Database.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_Lop_GetAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetMonHoc()
        {
            using SqlConnection conn = new SqlConnection(Database.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_MonHoc_GetAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetKetQuaByLopMon(string maLop, string maMon)
        {
            using SqlConnection conn = new SqlConnection(Database.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_KetQua_GetByLopMon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@MaMon", maMon);

            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int SaveAll(string maMon, DataTable dtKetQua)
        {
            using SqlConnection conn = new SqlConnection(Database.ConnectionString);
            conn.Open();

            using SqlTransaction trans = conn.BeginTransaction();
            try
            {
                int soDongLuu = 0;

                foreach (DataRow row in dtKetQua.Rows)
                {
                    if (row.RowState == DataRowState.Deleted)
                        continue;

                    string maSV = row["MaSV"]?.ToString() ?? "";
                    double diem = Convert.ToDouble(row["Diem"]);
                    string ghiChu = row["GhiChu"]?.ToString() ?? "";

                    using SqlCommand cmd = new SqlCommand("sp_KetQua_Save", conn, trans);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    cmd.ExecuteNonQuery();
                    soDongLuu++;
                }

                trans.Commit();
                return soDongLuu;
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
    }
}
