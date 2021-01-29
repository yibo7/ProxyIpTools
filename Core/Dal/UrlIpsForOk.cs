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
    public class UrlIpsForOk
    {
        public static readonly UrlIpsForOk Instane = new UrlIpsForOk();

        public void Add(Entity.UrlIpsForOk model)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                model.MdWu = XS.Core.XsUtils.MD5(string.Concat(model.Url, model.Ip,model.Port));
                //5e64f37a3e6760d626fd7aefa46737b9
                Entity.UrlIpsForOk mdIsHave = connection.QueryFirstOrDefault<Entity.UrlIpsForOk>(string.Format("select * from xs_urlipsforok where MdWu='{0}'", model.MdWu));
                if (!Equals(mdIsHave, null))
                {
                    model.Id = mdIsHave.Id;
                    connection.Update(model); 
                }
                else
                {
                    connection.Insert(model);//只有Id为自动增长类型时返回一个整数Id
                }
                
            }
        }

        public bool CheckIpIsOK(string MdWuIpPort)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                List<Entity.UrlIpsForOk> mdIsHaves = connection.Query<Entity.UrlIpsForOk>(string.Format("select * from xs_urlipsforok where MdWuIpPort='{0}' ", MdWuIpPort)).ToList();
                if (mdIsHaves.Count > 0)
                {
                    bool isOk = false;
                    foreach (var model in mdIsHaves)
                    {
                        return (model.IsOk == 1);

                    }
                }
                else //还没有投入使用
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(Entity.UrlIpsForOk model)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Update(model);
            }
        }


        public Entity.UrlIpsForOk GetEntity(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Get<Entity.UrlIpsForOk>(Id);
            }
        }


        public Entity.UrlIpsForOk GetEntityByMdWu(string mdwu)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {//5e64f37a3e6760d626fd7aefa46737b9
                  Entity.UrlIpsForOk mdIsHave = connection.QueryFirstOrDefault<Entity.UrlIpsForOk>(string.Format("select * from xs_urlipsforok where MdWu='{0}'", mdwu));
                return mdIsHave;//connection.QueryFirst<Entity.UrlIpsForOk>(string.Format("select * from xs_urlipsforok where Name like '%{0}%'", key));
            }
        }


        public List<Entity.UrlIpsForOk> GetEntityList(string key)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.UrlIpsForOk>(string.Format("select * from xs_urlipsforok where Computed like '%{0}%'", key)).ToList();
            }
        }


        public void DeleteModel(int Id)
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.Delete(new Entity.UrlIpsForOk() { Id = Id });
            }
        }


        public void DeleteAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                connection.DeleteAll<Entity.UrlIpsForOk>();
            }
        }


        public List<Entity.UrlIpsForOk> GetAll()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {

                return connection.GetAll<Entity.UrlIpsForOk>().ToList();
            }
        }


        public List<Entity.UrlIpsForOk> GetAllSql()
        {
            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.UrlIpsForOk>("select * from xs_urlipsforok").ToList();
            }
        }
        /// <summary>
        /// 获取统计
        /// </summary>

        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select count(*)  from {0}urlipsforok ", "xs_");
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


        public List<Entity.UrlIpsForOk> GetListPages(int PageIndex, int PageSize, string strWhere, string Fileds, string oderby, out int RecordCount)
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
            string strSql = SplitPages.GetSplitPagesMySql(DataUtils.GetOpenConnection(), "xs_urlipsforok", PageSize, PageIndex, strWhere, "Id", Fileds, "", oderby);

            using (var connection = DataUtils.GetOpenConnection())
            {
                return connection.Query<Entity.UrlIpsForOk>(strSql).ToList();
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
