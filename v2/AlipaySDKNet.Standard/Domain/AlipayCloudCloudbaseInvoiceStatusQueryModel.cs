using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseInvoiceStatusQueryModel : AopObject
    {
        /// <summary>
        /// 开票记录uuid
        /// </summary>
        [XmlElement("open_api_id")]
        public string OpenApiId { get; set; }
    }
}
