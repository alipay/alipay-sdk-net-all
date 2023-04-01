using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseserviceBindserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseserviceBindserviceQueryModel : AopObject
    {
        /// <summary>
        /// 企业服务产品id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
