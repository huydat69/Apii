﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    interface DonHangRepository:IDonHangRepository
    {
        public List<DonHangModel> GetDonHang()
        {
            return null;
        }
    }
}
