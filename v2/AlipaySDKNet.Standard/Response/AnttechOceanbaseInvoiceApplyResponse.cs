using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseInvoiceApplyResponse.
    /// </summary>
    public class AnttechOceanbaseInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请单业务主键
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
