using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class Hocvien
    {
		string MaHV;
		string TenHV;
		string GioiTinh;
		string Chucvu;
		string Capbac;
		string Malop;

		public string MaHV1 { get => MaHV; set => MaHV = value; }
		public string TenHV1 { get => TenHV; set => TenHV = value; }
		public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
		public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
		public string Capbac1 { get => Capbac; set => Capbac = value; }
		public string Malop1 { get => Malop; set => Malop = value; }
        public Hocvien(string _MaHV, string _TenHV, string _GioiTinh, string _Chucvu, string _Capbac, string _Malop)
        {
            MaHV = _MaHV;
            TenHV = _TenHV;
            GioiTinh = _GioiTinh;
            Chucvu = _Chucvu;
            Capbac = _Capbac;
            Malop = _Malop;
        }
        public Hocvien(string[] data)
        {
            MaHV = data[0];
            Malop = data[1];
            GioiTinh = data[2];
            Chucvu = data[3];
            Capbac = data[4];
            TenHV = data[5];
        }
        public static Hocvien getmaHv(string Malop)
        {
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("spgetMaHV", CommandType.StoredProcedure,
                new string[1] { "@MaHV" }, new object[1] { Malop });
            var obj = dt.Rows[0].ItemArray;
            var data = obj.Where(x => x != null)
                       .Select(x => x.ToString())
                       .ToArray();
            return new Hocvien(data);
        }
        public static List<List<string>> getHv()
        {
            List<List<string>> re = new List<List<string>>();
            List<string> maNV = new List<string>();
            List<string> matKhau = new List<string>();
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("Select MaHV,MaLop from Hocvien", CommandType.Text);
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
