using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoanWebNhomPV.Model
{
    public class SANPHAM
    {
        public int masp { get;set; }
        public string tensp { get; set; }
        public int dongia { get; set; }
        public string mota { get; set; }
        public string anh { get; set; }
        public bool isactive { get; set; }
    }
}