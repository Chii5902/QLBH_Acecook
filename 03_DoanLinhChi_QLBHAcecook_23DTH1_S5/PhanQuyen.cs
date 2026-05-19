using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DoanLinhChi_QLBHAcecook_23DTH1_S5
{
    internal class PhanQuyen
    {
        public static class SessionManager
        {
            public static string MaNV { get; set; }
            public static string VaiTro { get; set; }
            public static string TenDangNhap { get; set; }

            public static void Logout()
            {
                MaNV = null;
                VaiTro = null;
                TenDangNhap = null;
            }
        }
    }
}
