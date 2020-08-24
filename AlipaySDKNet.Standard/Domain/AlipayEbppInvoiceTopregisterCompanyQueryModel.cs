using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTopregisterCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 业务平台Code,由发票中台分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
