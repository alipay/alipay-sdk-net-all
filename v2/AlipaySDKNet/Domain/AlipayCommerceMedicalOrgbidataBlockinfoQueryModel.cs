using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrgbidataBlockinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrgbidataBlockinfoQueryModel : AopObject
    {
        /// <summary>
        /// 数据聚合的天数，eg:1d，一天 7d,七天 30d,一个月
        /// </summary>
        [XmlElement("aggr_day")]
        public string AggrDay { get; set; }

        /// <summary>
        /// 机构统计聚合数:可选类型如下：  "org_aggr_statistics", "org_statistics_detail"
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 查询汇总数据的日期，eg:20250501,2025年5月1日
        /// </summary>
        [XmlElement("data_dt")]
        public string DataDt { get; set; }

        /// <summary>
        /// 机构的统一社会信用码
        /// </summary>
        [XmlElement("scc")]
        public string Scc { get; set; }
    }
}
