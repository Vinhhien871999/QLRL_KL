using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class QLDD
    {
        private string maQL;
        private string matkhau;
        private string hoten;
        private string chucvu;
        private string capbac;

        public string MaQL { get => maQL; set => maQL = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Capbac { get => capbac; set => capbac = value; }
        public QLDD(string _MaQL, string _Matkhau, string _Hoten,
            string _Chucvu, string _Capbac)
        {
            MaQL = _MaQL;
            Matkhau = _Matkhau;
            Hoten = _Hoten;
            Chucvu = _Chucvu;
            Capbac = _Capbac;
        }
        public QLDD(string[] data)
        {
            MaQL = data[0];
            Matkhau = data[1];
            Hoten = data[2];
            Chucvu = data[3];
            Capbac = data[4];
        }
        public static QLDD getMaQL(string MaQL)
        {
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("spgetMaQl", CommandType.StoredProcedure,
                new string[1] { "@MaQL" }, new object[1] { MaQL });
            var obj = dt.Rows[0].ItemArray;
            var data = obj.Where(x => x != null)
                       .Select(x => x.ToString())
                       .ToArray();
            return new QLDD(data);
        }
        public static List<List<string>> getMaQL()
        {
            List<List<string>> re = new List<List<string>>();
            List<string> maNV = new List<string>();
            List<string> matKhau = new List<string>();
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("Select MaQL,Matkhau from Quanly", CommandType.Text);
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
