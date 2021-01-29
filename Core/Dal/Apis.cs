using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Data.Sqlite;
using XS.DataProfile;
using XS.DataProfile.Dapper.Contrib;

namespace ProxyIpTools.Core.Dal
{
    public class Apis
    {
        public static readonly Apis Instane = new Apis();

        public void Add(Entity.Apis model)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.Insert(model);//只有Id为自动增长类型时返回一个整数Id
            }
        }


        public bool Update(Entity.Apis model)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Update(model);
            }
        }


        public Entity.Apis GetEntity(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Get<Entity.Apis>(Id);
            }
        }


        public Entity.Apis GetEntityBySql(string key)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.QueryFirst<Entity.Apis>(string.Format("select * from xs_apis where Name like '%{0}%'", key));
            }
        }


        public List<Entity.Apis> GetEntityList(string key)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Apis>(string.Format("select * from xs_apis where Computed like '%{0}%'", key)).ToList();
            }
        }


        public void DeleteModel(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.Delete(new Entity.Apis() { Id = Id });
            }
        }


        public void DeleteAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.DeleteAll<Entity.Apis>();
            }
        }


        public List<Entity.Apis> GetAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {

                return connection.GetAll<Entity.Apis>().ToList();
            }
        }


        public List<Entity.Apis> GetAllSql()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Apis>("select * from xs_apis").ToList();
            }
        }
        /// <summary>
        /// 获取统计
        /// </summary>

        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select count(*)  from {0}apis ", "xs_");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            int iCount = 0;
            using (var connection = DataUtils.GetOpenConnection())
            {
                iCount = connection.QuerySingleOrDefault<int>(strSql.ToString());
            }
            return iCount;
        }


        public List<Entity.Apis> GetListPages(int PageIndex, int PageSize, string strWhere, string Fileds, string oderby, out int RecordCount)
        {

            StringBuilder sbSql = new StringBuilder();
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.AppendFormat(strWhere);
            }
            RecordCount = GetCount(sbSql.ToString());

            //获取SqlServer2005及以上版的分页查询语句 
            //string strSql = SplitPages.GetListPagesSql2005("B_Part", PageSize, PageIndex, Fileds,  strWhere);

            //获取SqlServer2000或access分页查询语句 
            //string strSql = SplitPages.GetSplitPagesSql("B_Part", PageSize, PageIndex, Fileds, "PartInno", "", strWhere, "");

            //获取MySql或SQLite分页查询语句 ,MySql与SQLite的查询语句基本一样，所以GetSplitPagesMySql适用于MySql与SQLite
            string strSql = SplitPages.GetSplitPagesMySql(DataUtils.GetOpenConnection(), "xs_apis", PageSize, PageIndex, strWhere, "Id", Fileds, "", oderby);

            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Apis>(strSql).ToList();
            }
        }

        //public void Transactions()
        //{
        //    using (var connection = Utils.GetOpenConnection())
        //    {
        //        var id = connection.Insert(new Entity.Apis { Name = "one car" });
        //        var tran = connection.BeginTransaction();
        //        var car = connection.Get<BPart>(id, tran);
        //        var orgName = car.Name;
        //        car.Name = "Another car";
        //        connection.Update(car, tran);
        //        tran.Rollback();
        //        car = connection.Get<BPart>(id);
        //    }
        //}
    }
}
