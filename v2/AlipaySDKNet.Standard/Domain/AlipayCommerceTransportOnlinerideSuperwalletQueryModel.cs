using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOnlinerideSuperwalletQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOnlinerideSuperwalletQueryModel : AopObject
    {
        /// <summary>
        /// 业务请求来源， 首页：HOME_PAGE 发单页：ORDER_PAGE
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

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
