using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKiluat.Models
{
    class giamsat
    {
        string Mags;
        string Tennguoigiamsat;
        string Chucvu;
        string Capbac;

        public string Mags1 { get => Mags; set => Mags = value; }
        public string Tennguoigiamsat1 { get => Tennguoigiamsat; set => Tennguoigiamsat = value; }
        public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
        public string Capbac1 { get => Capbac; set => Capbac = value; }
        public giamsat(string _Mags, string _Tennguoigiamsat, string _Chucvu, string _Capbac)
        {
            Mags = _Mags;
            Tennguoigiamsat = _Tennguoigiamsat;
            Chucvu = _Chucvu;
            Capbac = _Capbac;
        }
        public giamsat(string[] data)
        {
            Mags = data[0];
            Tennguoigiamsat = data[1];
            Chucvu = data[2];
            Capbac = data[3];
        }
        public static DataTable getTableGiamsat()
        {
            return Models.Connection.getData("spgettablegiamsat", CommandType.StoredProcedure);
        }
    }
}
