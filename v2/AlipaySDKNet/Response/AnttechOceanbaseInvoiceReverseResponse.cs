using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseInvoiceReverseResponse.
    /// </summary>
    public class AnttechOceanbaseInvoiceReverseResponse : AopResponse
    {
        /// <summary>
        /// 红冲申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
