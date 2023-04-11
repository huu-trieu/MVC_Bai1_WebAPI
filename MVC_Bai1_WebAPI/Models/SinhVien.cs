using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Bai1_WebAPI.Models
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public SinhVien() 
        {
            MSSV = "3119411084";
            Ten = "Nguyễn Hữu Triều";
            Tuoi = 22;
        }

    }
}