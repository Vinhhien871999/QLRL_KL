using System;
using System.Collections.Generic;
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
            TenHV = data[1];
            GioiTinh = data[2];
            Chucvu = data[3];
            Capbac = data[4];
            Malop = data[5];
        }
    }
}
