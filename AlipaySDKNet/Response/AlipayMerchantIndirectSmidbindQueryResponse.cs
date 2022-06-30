using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectSmidbindQueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectSmidbindQueryResponse : AopResponse
    {
        /// <summary>
        /// 确认状态，枚举：已确认（AUTHORIZED）/未确认（UNAUTHORIZED）/已销户（CLOSED）
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }
    }
}
