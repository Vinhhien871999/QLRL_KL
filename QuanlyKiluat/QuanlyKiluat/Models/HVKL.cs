using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class HVKL
    {
		string Mahv_plkl;
		string Thoigian;
		string MaHV;
		string MaPLKL;
		string Capdanhgia;
		string Nguoidanhgia;
		string Diemkiluat;
		string Diemhoctap;
		string Diemloisong;
		string Diemhoatdongdoan;

		public string Mahv_plkl1 { get => Mahv_plkl; set => Mahv_plkl = value; }
		public string Thoigian1 { get => Thoigian; set => Thoigian = value; }
		public string MaHV1 { get => MaHV; set => MaHV = value; }
		public string MaPLKL1 { get => MaPLKL; set => MaPLKL = value; }
		public string Capdanhgia1 { get => Capdanhgia; set => Capdanhgia = value; }
		public string Nguoidanhgia1 { get => Nguoidanhgia; set => Nguoidanhgia = value; }
		public string Diemkiluat1 { get => Diemkiluat; set => Diemkiluat = value; }
		public string Diemhoctap1 { get => Diemhoctap; set => Diemhoctap = value; }
		public string Diemloisong1 { get => Diemloisong; set => Diemloisong = value; }
		public string Diemhoatdongdoan1 { get => Diemhoatdongdoan; set => Diemhoatdongdoan = value; }

        public HVKL(string _Thoigian, string _MaHV, string _MaPLKL, string _Capdanhgia, string _Nguoidanhgia, string _Diemkiluat, string _Diemhoctap, string _Diemloisong, string _Diemhoatdongdoan)
        {
            Thoigian = _Thoigian;
            MaHV = _MaHV;
            MaPLKL = _MaPLKL;
            Capdanhgia = _Capdanhgia;
            Nguoidanhgia = _Nguoidanhgia;
            Diemkiluat = _Diemkiluat;
            Diemhoctap = _Diemhoctap;
            Diemloisong = _Diemloisong;
            Diemhoatdongdoan = _Diemhoatdongdoan;
        }
        public HVKL(string _Mahv_plkl, string _Thoigian, string _MaHV, string _MaPLKL, string _Capdanhgia, string _Nguoidanhgia, string _Diemkiluat, string _Diemhoctap, string _Diemloisong, string _Diemhoatdongdoan)
        {
            Mahv_plkl = _Mahv_plkl;
            Thoigian = _Thoigian;
            MaHV = _MaHV;
            MaPLKL = _MaPLKL;
            Capdanhgia = _Capdanhgia;
            Nguoidanhgia = _Nguoidanhgia;
            Diemkiluat = _Diemkiluat;
            Diemhoctap = _Diemhoctap;
            Diemloisong = _Diemloisong;
            Diemhoatdongdoan = _Diemhoatdongdoan;
        }
        public HVKL(string[] data)
        {
            Mahv_plkl = data[0];
            Thoigian = data[1];
            MaHV = data[2];
            MaPLKL = data[3];
            Capdanhgia = data[4];
            Nguoidanhgia = data[5];
            Diemkiluat = data[6];
            Diemhoctap = data[7];
            Diemloisong = data[8];
            Diemhoatdongdoan = data[9];
        }
        public int InsertHVKL()
        {
            string[] paras = new string[10] { "@Mahv_plkl", "@Thoigian", "@MaHV",
                "@MaPLKL", "@Capdanhgia", "@Nguoidanhgia","@Diemkiluat", "@Diemhoctap", "@Diemloisong","@Diemhoatdongdoan"};
            object[] values = new object[10] { Mahv_plkl, Thoigian, MaHV, MaPLKL, Capdanhgia, Nguoidanhgia, Diemkiluat, Diemhoctap, Diemloisong, Diemhoatdongdoan };
            var i = Models.Connection.ExcuteQuery("insert_HVKL",
                System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHVKL()
        {
            string[] paras = new string[10] { "@Mahv_plkl", "@Thoigian", "@MaHV",
                "@MaPLKL", "@Capdanhgia", "@Nguoidanhgia","@Diemkiluat", "@Diemhoctap", "@Diemloisong","@Diemhoatdongdoan"};
            object[] values = new object[10] { Mahv_plkl, Thoigian, MaHV, MaPLKL, Capdanhgia, Nguoidanhgia, Diemkiluat, Diemhoctap, Diemloisong, Diemhoatdongdoan };
            var i = Models.Connection.ExcuteQuery("update_HVKL",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataTable getmahvrl()
        {
            return Models.Connection.getData("getmaplkl", CommandType.StoredProcedure);
        }
        public static DataTable gettableplkl()
        {
            return Models.Connection.getData("spgettableplkl", CommandType.StoredProcedure);
        }
        public static DataTable gettablehvplkl(string MaHV)
        {
            DataTable dt = new DataTable();
            dt = Models.Connection.getData("spgettablehvplkl", CommandType.StoredProcedure,
                new string[1] { "@MaHV" }, new object[1] { MaHV });
            return dt;
        }
    }
}
