﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Object
{
    class BaoCaoCongNoObj
    {
        private string maBaoCaoCongNo;
        private DateTime thang;
        public string MaBaoCaoCongNo { get => maBaoCaoCongNo; set => maBaoCaoCongNo = value; }
        public DateTime Thang { get => thang; set => thang = value; }
    }
}

