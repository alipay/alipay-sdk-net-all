using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportPromoTasklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportPromoTasklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize")]
        public string Prize { get; set; }

        /// <summary>
        /// 奖品价格单位分
        /// </summary>
        [XmlElement("prize_price")]
        public string PrizePrice { get; set; }
    }
}
