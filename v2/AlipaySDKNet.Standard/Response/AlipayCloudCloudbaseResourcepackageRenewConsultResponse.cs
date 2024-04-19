using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageRenewConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageRenewConsultResponse : AopResponse
    {
        /// <summary>
        /// 币种  - CNY  - USD  - EUR
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 折扣后总价(分)
        /// </summary>
        [XmlElement("trade_total_amount")]
        public string TradeTotalAmount { get; set; }
    }
}
