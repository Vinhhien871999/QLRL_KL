using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class HVRL
    {
        string Mahv_plrl;
        string Thoigian;
        string MaHV;
        string MaPLRL;
        string MaGS;
        string Boi;
        string Chaydai;
        string Chayngan;
        string nhayxa;
        string xa;

        
        public string Mahv_plrl1 { get => Mahv_plrl; set => Mahv_plrl = value; }
        public string Thoigian1 { get => Thoigian; set => Thoigian = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string MaPLRL1 { get => MaPLRL; set => MaPLRL = value; }
        public string MaGS1 { get => MaGS; set => MaGS = value; }
        public string Boi1 { get => Boi; set => Boi = value; }
        public string Chaydai1 { get => Chaydai; set => Chaydai = value; }
        public string Chayngan1 { get => Chayngan; set => Chayngan = value; }
        public string Nhayxa { get => nhayxa; set => nhayxa = value; }
        public string Xa { get => xa; set => xa = value; }

        public HVRL(string _Mahv_plrl, string _Thoigian, string _MaHV, string _MaPLRL, string _MaGS, string _Boi, string _Chaydai, string _Chayngan, string _nhayxa, string _xa)
        {
            Mahv_plrl = _Mahv_plrl;
            Thoigian = _Thoigian;
            MaHV = _MaHV;
            MaPLRL = _MaPLRL;
            MaGS = _MaGS;
            Boi1 = _Boi;
            Chaydai1 = _Chaydai;
            Chayngan1 = _Chayngan;
            Nhayxa = _nhayxa;
            Xa = _xa;
        }
        public HVRL(string _Thoigian, string _MaHV, string _MaPLRL, string _MaGS, string _Boi, string _Chaydai, string _Chayngan, string _nhayxa, string _xa)
        {
            Thoigian = _Thoigian;
            MaHV = _MaHV;
            MaPLRL = _MaPLRL;
            MaGS = _MaGS;
            Boi1 = _Boi;
            Chaydai1 = _Chaydai;
            Chayngan1 = _Chayngan;
            Nhayxa = _nhayxa;
            Xa = _xa;
        }
        public HVRL(string[] data)
        {
            Mahv_plrl = data[0];
            Thoigian = data[1];
            MaHV = data[2];
            MaPLRL = data[3];
            MaGS = data[4];
            Boi1 = data[5];
            Chaydai1 = data[6];
            Chayngan1 = data[7];
            Nhayxa = data[8];
            Xa = data[9];
        }
        public int InsertHVRL()
        {
            string[] paras = new string[10] { "@Mahv_plrl", "@Thoigian", "@MaHV",
                "@MaPLRL", "@MaGS", "@Boi","@Chaydai", "@Chayngan", "@nhayxa","@xa"};
            object[] values = new object[10] { Mahv_plrl, Thoigian, MaHV, MaPLRL, MaGS, Boi1, Chaydai1, Chayngan1, Nhayxa, Xa };
            var i = Models.Connection.ExcuteQuery("insert_HVRL",
                System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHVRL()
        {
            string[] paras = new string[10] { "@Mahv_plrl", "@Thoigian", "@MaHV",
                "@MaPLRL", "@MaGS", "@Boi","@Chaydai", "@Chayngan", "@nhayxa","@xa"};
            object[] values = new object[10] { Mahv_plrl, Thoigian, MaHV, MaPLRL, MaGS, Boi1, Chaydai1, Chayngan1, Nhayxa, Xa };
            var i = Models.Connection.ExcuteQuery("update_HVRL",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataTable getmahvrl()
        {
            return Models.Connection.getData("getmaplrl", CommandType.StoredProcedure);
        }
        public static DataTable gettableplrl()
        {
            return Models.Connection.getData("spgettableplrl", CommandType.StoredProcedure);
        }
    }
}
