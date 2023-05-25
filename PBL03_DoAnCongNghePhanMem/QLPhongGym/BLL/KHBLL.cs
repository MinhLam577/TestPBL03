﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
namespace QLPhongGym.BLL
{
    public class KHBLL:UsersBLL
    {
        private static KHBLL  instance;
        public static KHBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new KHBLL();
                return instance;
            }
            private set { }
        }
        public DataTable SortListKHBy(string Require, DataTable data)
        {
            return KHDAL.Instance.SortKHBy(Require, data);
        }
        public DataTable FindListKHByIDOrName(string txt)
        {
            return KHDAL.Instance.FindListKHByIDOrName(txt);
        }
        
    }
}
