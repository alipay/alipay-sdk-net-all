using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourTokenExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourTokenExchangeModel : AopObject
    {
        /// <summary>
        /// 一码通码值的codeToken
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// 需要换码用户的userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝行业库的景区ID，只有接入了一码付方案的景区才能通过该接口校验
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 需要换码用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
