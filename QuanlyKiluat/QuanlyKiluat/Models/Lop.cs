using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class Lop
    {

        string MaLop;
        string Matkhau;
        string Tenlop;
        string MaDD;

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string Matkhau1 { get => Matkhau; set => Matkhau = value; }
        public string Tenlop1 { get => Tenlop; set => Tenlop = value; }
        public string MaDD1 { get => MaDD; set => MaDD = value; }

        public Lop(string _MaLop, string _Matkhau, string _Tenlop,string _MaDD)
        {
            MaLop = _MaLop;
            Matkhau = _Matkhau;
            Tenlop = _Tenlop;
            MaDD = _MaDD;
        }
        public Lop(string[] data)
        {
            MaLop = data[0];
            Matkhau = data[1];
            Tenlop = data[2];
            MaDD = data[3];
        }
        public static DataTable getTableLop()
        {
            return Models.Connection.getData("spgetTableAllLop", CommandType.StoredProcedure);
        }
        public static Lop getLop(string Malop)
        {
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("spgetMaLop", CommandType.StoredProcedure,
                new string[1] { "@Malop" }, new object[1] { Malop });
            var obj = dt.Rows[0].ItemArray;
            var data = obj.Where(x => x != null)
                       .Select(x => x.ToString())
                       .ToArray();
            return new Lop(data);
        }
        public static List<List<string>> getmalop()
        {
            List<List<string>> re = new List<List<string>>();
            List<string> maNV = new List<string>();
            List<string> matKhau = new List<string>();
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("Select MaLop,Matkhau from Lop", CommandType.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                maNV.Add(dt.Rows[i][0].ToString().Trim());
                matKhau.Add(dt.Rows[i][1].ToString().Trim());
            }
            re.Add(maNV);
            re.Add(matKhau);
            Console.Write(matKhau.Count);
            return re;
        }
    }
}
