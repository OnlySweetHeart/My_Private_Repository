﻿using Company.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Company.Dao
{
    public class CompanyInfoDao
    {
        public static string conStr = SqlHelper.GetConnString();
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns></returns>
        public List<CompanyInfo> SelectCompanyInfo()
        {
            List<CompanyInfo> list = new List<CompanyInfo>();
            string sqlstr = "select * from tab_CompanyInfo where 1=1";
            DataSet ds = SqlHelper.ExecuteDataset(conStr, CommandType.Text, sqlstr);
            list.ConvertTableToList(ds.Tables[0]);
            return list;
        }
    }
}