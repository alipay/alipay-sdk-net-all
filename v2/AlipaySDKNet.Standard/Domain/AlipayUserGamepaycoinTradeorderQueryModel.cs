using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamepaycoinTradeorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamepaycoinTradeorderQueryModel : AopObject
    {
        /// <summary>
        /// 开发者自定义订单号，在下单的时候传入的customId
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
