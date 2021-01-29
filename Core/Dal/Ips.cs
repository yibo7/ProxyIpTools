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
    public class Ips
    {
        public static readonly Ips Instane = new Ips();

        public bool Add(Entity.Ips model)
        {

            using (var connection = DataUtils.GetOpenConnection())
            {
                model.MdWu = XS.Core.XsUtils.MD5(string.Concat(model.Ip, model.Port));
                Entity.Ips mdIsHave = connection.QueryFirstOrDefault<Entity.Ips>(string.Format("select * from xs_ips where MdWu ='{0}'", model.Ip));
                if (Equals(mdIsHave,null))
                {
                    connection.Insert(model); //只有Id为自动增长类型时返回一个整数Id
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }


        public bool Update(Entity.Ips model)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Update(model);
            }
        }


        public Entity.Ips GetEntity(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Get<Entity.Ips>(Id);
            }
        }


        public Entity.Ips GetEntityByIp(string ip)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.QueryFirst<Entity.Ips>(string.Format("select * from xs_ips where Ip ='{0}'", ip));
            }
        }


        public List<Entity.Ips> GetListByIp(string ip)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Ips>(string.Format("select * from xs_ips where Ip ='{0}'", ip)).ToList();
            }
        }


        public void DeleteModel(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.Delete(new Entity.Ips() { Id = Id });
            }
        }


        public void DeleteAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.DeleteAll<Entity.Ips>();
            }
        }

        public void DelIpForBad()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                //connection.Query<string>("DELETE FROM xs_ips WHERE IsOk=0");
                connection.Execute("DELETE FROM xs_ips WHERE IsOk=0");
            }
        }

        public List<Entity.Ips> GetAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {

                return connection.GetAll<Entity.Ips>().ToList();
            }
        }


        public List<Entity.Ips> GetAllSql()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Ips>("select * from xs_ips").ToList();
            }
        }
        /// <summary>
        /// 获取统计
        /// </summary>

        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select count(*)  from {0}ips ", "xs_");
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


        public List<Entity.Ips> GetListPages(int PageIndex, int PageSize, string strWhere, string Fileds, string oderby, out int RecordCount)
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
            string strSql = SplitPages.GetSplitPagesMySql(DataUtils.GetOpenConnection(), "xs_ips", PageSize, PageIndex, strWhere, "Id", Fileds, "", oderby);

            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.Ips>(strSql).ToList();
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
