using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipaySubscribePortalSessionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipaySubscribePortalSessionCreateModel : AopObject
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 门户公开编码(10位) 在商家平台获取的门户编码
        /// </summary>
        [XmlElement("portal_code")]
        public string PortalCode { get; set; }
    }
}
