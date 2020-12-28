using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class QuyChuan
    {
		string MaQCRL;
		string Noidung;
		string Donvitinh;
		string Gioi;
		string Kha;
		string Trungbinh;

		public string MaQCRL1 { get => MaQCRL; set => MaQCRL = value; }
		public string Noidung1 { get => Noidung; set => Noidung = value; }
		public string Donvitinh1 { get => Donvitinh; set => Donvitinh = value; }
		public string Gioi1 { get => Gioi; set => Gioi = value; }
		public string Kha1 { get => Kha; set => Kha = value; }
		public string Trungbinh1 { get => Trungbinh; set => Trungbinh = value; }

        public QuyChuan(string _MaQCRL, string _Noidung, string _Donvitinh, string _Gioi, string _Kha, string _Trungbinh)
        {
            MaQCRL = _MaQCRL;
            Noidung = _Noidung;
            Donvitinh = _Donvitinh;
            Gioi = _Gioi;
            Kha = _Kha;
            Trungbinh = _Trungbinh;
        }
        public QuyChuan(string[] data)
        {
            MaQCRL = data[0];
            Noidung = data[1];
            Donvitinh = data[2];
            Gioi = data[3];
            Kha = data[4];
            Trungbinh = data[5];
        }
        public static DataTable getTableQuyChuanKL()
        {
            return Models.Connection.getData("spgettablequychuanKL", CommandType.StoredProcedure);
        }
        public static DataTable getTableQuyChuanRL()
        {
            return Models.Connection.getData("spgettablequychuanRl", CommandType.StoredProcedure);
        }
    }
}
