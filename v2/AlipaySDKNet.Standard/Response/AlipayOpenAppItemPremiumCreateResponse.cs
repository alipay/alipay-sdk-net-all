using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemPremiumCreateResponse.
    /// </summary>
    public class AlipayOpenAppItemPremiumCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 提报结果描述
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
