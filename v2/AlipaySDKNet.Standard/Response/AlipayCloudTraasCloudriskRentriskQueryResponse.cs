using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudTraasCloudriskRentriskQueryResponse.
    /// </summary>
    public class AlipayCloudTraasCloudriskRentriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险咨询事件ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 风险等级中文描述
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 综合风险
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }

        /// <summary>
        /// 综合风险的风险等级
        /// </summary>
        [XmlElement("risk_rank")]
        public string RiskRank { get; set; }

        /// <summary>
        /// 子风险项
        /// </summary>
        [XmlElement("sub_rent_risk_result")]
        public SubRentRiskResult SubRentRiskResult { get; set; }

        /// <summary>
        /// 子风险结果列表
        /// </summary>
        [XmlArray("sub_risk_result_list")]
        [XmlArrayItem("sub_rent_risk_item")]
        public List<SubRentRiskItem> SubRiskResultList { get; set; }
    }
}
