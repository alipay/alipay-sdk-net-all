using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemPremiumCancelResponse.
    /// </summary>
    public class AlipayOpenAppItemPremiumCancelResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
