using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanInsightcityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanInsightcityQueryModel : AopObject
    {
        /// <summary>
        /// 人群id，按人群分析时必传
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 用户关系类型，不传人群id时必传
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 数据日期，格式yyyyMMdd，非必填。由于数据每天可能有变化，可以指定数据对应的日期，指定后可以查询日期对应的数据计算结果，不填默认返回前一天的数据
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
