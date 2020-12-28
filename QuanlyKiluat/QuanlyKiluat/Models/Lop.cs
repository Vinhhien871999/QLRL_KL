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
    }
}
