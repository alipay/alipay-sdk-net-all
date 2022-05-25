using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolserviceOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolserviceOfflineModel : AopObject
    {
        /// <summary>
        /// 支付宝返回的服务唯一ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
