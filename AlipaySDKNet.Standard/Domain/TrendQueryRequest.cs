using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrendQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TrendQueryRequest : AopObject
    {
        /// <summary>
        /// 时间维度的聚合会对用户去重。
        /// </summary>
        [XmlElement("dim")]
        public string Dim { get; set; }

        /// <summary>
        /// 趋势图结束时间，格式yyyyMMdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 是否排除在棋盘导入的用户，导入方式包括文件上传和接口上传。只适用于总用户资产趋势的查询（index_key=total_users），设true则可查询访问、互动和支付用户的三大类总用户趋势。
        /// </summary>
        [XmlElement("exclude_import")]
        public bool ExcludeImport { get; set; }

        /// <summary>
        /// 用户资产关系类型，查询单日行为用户趋势（index_key=new_user_num）和查询支付占比趋势（index_key=pay_users_perc）时必填。
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 趋势图开始时间，格式yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户指标趋势查询（index_key=user_indications）时必填。
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }
    }
}
