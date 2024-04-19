using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanInsightQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanInsightQueryModel : AopObject
    {
        /// <summary>
        /// 人群id，按人群分析时必传
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 商家按需选择传入的洞察维度，但该接口不包含常住省市的数据。如需查询常住省市，使用alipay.merchant.qipan.insightcity.query接口
        /// </summary>
        [XmlArray("portr_type_list")]
        [XmlArrayItem("string")]
        public List<string> PortrTypeList { get; set; }

        /// <summary>
        /// 用户关系类型，不传人群id时必传。如果人群id不为空，优先查询人群id对应的画像。
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 数据日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
