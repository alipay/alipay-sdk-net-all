using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityOwnercardCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝证件id
        /// </summary>
        [XmlElement("alipay_card_id")]
        public string AlipayCardId { get; set; }
    }
}
