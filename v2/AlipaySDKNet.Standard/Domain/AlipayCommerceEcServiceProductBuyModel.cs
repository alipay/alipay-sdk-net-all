using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcServiceProductBuyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcServiceProductBuyModel : AopObject
    {
        /// <summary>
        /// 企业ID，用于水平权限鉴权。通过alipay.commerce.ec.enterprise.change.notify获取
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业码服务ID，指定需要订购的服务。线下联系企业码小二获取
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
