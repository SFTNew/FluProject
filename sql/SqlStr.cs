using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluCreate.sql
{
    class SqlStr
    {
        #region 出院小结
        public static string CyxjSql(string start,string end)
        {
            string sql = @"select                                                                                                                " +
                        "zyid,                                                                                                                 " +
                        "bah as P3,                                                                                                            " +
                        "xm as P4,                                                                                                             " +
                        "case xb when '男'then 1 when '女' then 2 else 0 end as P5,	                                                           " +
                        "nl as P7,	                                                                                                           " +
                        "rysj as P22,                                                                                                          " +
                        "case ryksid  when 'KS00000002' then '05' when 'KS00000004' then '07' else '69' end as P23,                            " +
                        "zkkb as P24,	                                                                                                       " +
                        "cysj as P25,                                                                                                          " +
                        "case cyksid  when 'KS00000002' then '05' when 'KS00000004' then '07' else '69' end as   P26,                          " +
                        "zyts as P27,	                                                                                                       " +
                        "ysmzzd as P8600,	                                                                                                   " +
                        "yscyzd as P8601,	                                                                                                   " +
                        "rybq as P8602,	                                                                                                       " +
                        "cyqk as P8603,                                                                                                        " +
                        "null as P8604                                                                                                         " +
                        " from (                                                                                                               " +
                        "   select left(b.bm,3)  bm2,b.bm,a.yscyzd,a.rybq,a.cyqk,c.* from batj_cyzd a,dm_icd b,batj_baxx c                     " +
                        "    where a.baid=c.baid and a.icdid=b.icdid  and left(b.bm,1)='j' and c.rysj>'"+start+"'                             " +
                        " and c.rysj<='" + end+ "'"+
                        "  ) a where bm2>='j00' and bm2<='j99'  order by baid, bm2                                                             "; ;
            return sql;
        }
        #endregion

        #region 门诊和在院
        public static string MzhzySql(string start, string end)
        {
            string sql = @"select                                                                                               " +
                        "'4510250012' as P900,                                                                                " +
                        "'靖西市人民医院' as P6891,                                                                           " +
                        "'' as P686,                                                                                          " +
                        "'' as P800,	                                                                                      " +
                        "'01' as P7501,                                                                                       " +
                        "a.kh as P7502,	                                                                                      " +
                        "xm as P4,                                                                                            " +
                        "a.xb as P5,                                                                                          " +
                        "csrq P6,                                                                                             " +
                        "nl P7,                                                                                               " +
                        "'01' P7503,                                                                                          " +
                        "sfzh as P13,                                                                                         " +
                        "jzks as P7504,                                                                                       " +
                        "'1' as P7505,                                                                                        " +
                        "b.sfsj P7506,                                                                                        " +
                        "                                                                                                     " +
                        "'-' as P7507,                                                                                        " +
                        "'' as P321,                                                                                          " +
                        "mzzd as P322,                                                                                        " +
                        "'' as P324,                                                                                          " +
                        "'' as P325,                                                                                          " +
                        "'' as P327,                                                                                          " +
                        "'' as P328,                                                                                          " +
                        "'' as P3291,                                                                                         " +
                        "'' as P3292,                                                                                         " +
                        "'' as P3294,                                                                                         " +
                        "'' as P3295,                                                                                         " +
                        "'' as P3297,                                                                                         " +
                        "'' as P3298,                                                                                         " +
                        "'' as P3281,                                                                                         " +
                        "'' as P3282,                                                                                         " +
                        "'' as P3284,                                                                                         " +
                        "'' as P3285,                                                                                         " +
                        "'' as P3287,                                                                                         " +
                        "'' as P3288,                                                                                         " +
                        "'' as P3271,                                                                                         " +
                        "'' as P3272,                                                                                         " +
                        "'' as P3274,	                                                                                      " +
                        "'' as P3275,                                                                                         " +
                        "'' as P6911,                                                                                         " +
                        "'' as P6912,                                                                                         " +
                        "'' as P6913,                                                                                         " +
                        "'' as P6914,                                                                                         " +
                        "'' as P6915,                                                                                         " +
                        "'' as P6916,                                                                                         " +
                        "'' as P6917,                                                                                         " +
                        "'' as P6918,                                                                                         " +
                        "'' as P6919,                                                                                         " +
                        "'' as P6920,                                                                                         " +
                        "'' as P6921,                                                                                         " +
                        "'' as P6922,                                                                                         " +
                        "'' as P6923,                                                                                         " +
                        "'' as P6924,                                                                                         " +
                        "'' as P6925,                                                                                         " +
                        "fylb P1,                                                                                             " +
                        "总花费 as P7508,                                                                                     " +
                        "0 as P7509,                                                                                          " +
                        "中药费+西药费 as P7510,                                                                              " +
                        "检查费+化验费 as P7511,                                                                              " +
                        "grxjzf as P7512,                                                                                     " +
                        "2 as P8508,                                                                                          " +
                        "'' P8509                                                                                             " +
                        " from  mz_mzlgbr a,mz_mzzhf b where a.fph=b.fph  and b.sfsj>='" + start + "' and  b.sfsj<='" + end + "'  ";
            return sql;
        }
        #endregion

        #region 死亡记录
        public static string SwjlSql(string start, string end)
        {
            return "";
        }
        #endregion

        #region 出院流感病案
        public static string CylgblSql(string start, string end)
        {
            return "";
        }
        #endregion

        #region 检验记录
        public static string JyjlSql(string start, string end)
        {
            return "";
        }
        #endregion

        #region 用药记录
        public static string YyjlSql(string start, string end)
        {
            string sql = @"select                                                                                                                                                                   " +
                        "JZLX as P7501,	                                                                                                                                                          " +
                        "jzkh as P7502,                                                                                                                                                           " +
                        "substring(convert(varchar,jzsj,120),1,19) as P7506,	                                                                                                                  " +
                        "kdxh P7500,                                                                                                                                                              " +
                        "ypmc as P8016,                                                                                                                                                           " +
                        "plcs as P8017,	                                                                                                                                                          " +
                        "Convert(decimal(18,2),zl)  P8018,	                                                                                                                                      " +
                        "ycjl as P8019,	                                                                                                                                                          " +
                        "jldw as P8020,                                                                                                                                                           " +
                        "substring(convert(varchar,jzsj,120),1,19) as P8021,	                                                                                                                  " +
                        "substring(convert(varchar,endtime,120),1,19) as P8022                                                                                                                    " +
                        "from                                                                                                                                                                     " +
                        "(                                                                                                                                                                        " +
                        "   select '01' jzlx,kh as jzkh,kdxh,a.sfsj as jzsj,ypmc,plcs,ycjl,ycjl*sl as zl,jldw,a.sfsj as endtime from  mz_mzzhf a,                                                 " +
                        "	(                                                                                                                                                                     " +
                        "	  select a.kdxh,c.ypmc,b.plcs,a.ycjl,a.sl,a.jldw,d.fph from mzys_brcf a,dm_pl b,dm_yd c,mz_mzlgbr d                                                                   " +
                        "	   where a.ypid=c.ypid and a.yypl=b.plmc and a.kdh=d.kdh and datediff(dd,d.sfsj,getdate()) =1                                                                         " +
                        "    ) b where a.fph=b.fph                                                                                                                                                " +
                        "  union all                                                                                                                                                              " +
                        "  select * from                                                                                                                                                          " +
                        "    (                                                                                                                                                                    " +
                        "		  select '03' as jzlx,zyh as jzkh, 10000+yzh as kdxh,qrlrsj as jzsj,ypmc,plcs,ycjl,ycjl*ytyl as zl,a.jldw,zhzxsj as endtime  from v_bq_cqyz a,dm_yd b,            " +
                        "		   (                                                                                                                                                              " +
                        "			   select distinct zyid as zyid2,zyh from                                                                                                                     " +
                        "			   (                                                                                                                                                          " +
                        "				 select left(b.bm,3)  bm2,b.bm,a.yscyzd,a.rybq,a.cyqk,c.* from batj_cyzd a,dm_icd b,batj_baxx c                                                           " +
                        "				 where a.baid=c.baid and a.icdid=b.icdid  and left(b.bm,1)='j' and datediff(dd,c.cysj,getdate()) =1                                                       " +
                        "			   ) a where bm2>='j00' and bm2<='j99'                                                                                                                        " +
                        "		   ) c,dm_pl d where a.zyid=c.zyid2 and a.yzid=b.ypid and a.plid=d.plid and a.zlxmid='ZL00000004'                                                                 " +
                        "		   union all                                                                                                                                                      " +
                        "		  select '03' as jzlx,zyh as jzkh,30000+yzh as kdxh,qrlrsj as jzsj,ypmc,plcs,ycjl,ycjl*ytyl as zl,a.jldw,zhzxsj as endtime  from v_bq_lsyz a,dm_yd b,             " +
                        "			(                                                                                                                                                             " +
                        "			   select distinct zyid as zyid2,zyh from                                                                                                                     " +
                        "			   (                                                                                                                                                          " +
                        "				 select left(b.bm,3)  bm2,b.bm,a.yscyzd,a.rybq,a.cyqk,c.* from batj_cyzd a,dm_icd b,batj_baxx c                                                           " +
                        "				 where a.baid=c.baid and a.icdid=b.icdid  and left(b.bm,1)='j' and datediff(dd,c.cysj,getdate()) =1                                                       " +
                        "			   ) a where bm2>='j00' and bm2<='j99'                                                                                                                        " +
                        "			) c,dm_pl d where a.zyid=c.zyid2 and a.yzid=b.ypid and a.plid=d.plid and a.zlxmid='ZL00000004'                                                                " +
                        "	 )aa                                                                                                                                                                  " +
                        ") a                                                                                                                                                                      " +
                        "                                                                                                                                                                         ";
            return sql;
        }
        #endregion

        #region 存储过程名称
        public static string MZ_MZLGFY = "mz_mzlgfy";
        public static string MZ_MZLGPELBLE = "mz_mzlgpelble";
        #endregion
    }
}
