using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRecruitSettlementSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryRecruitSettlementSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝结算id
        /// </summary>
        [XmlElement("settlement_id")]
        public string SettlementId { get; set; }
    }
}
