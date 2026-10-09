using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardAcceptResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardAcceptResponse : AopResponse
    {
        /// <summary>
        /// 福卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 福卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }
    }
}
