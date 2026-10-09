using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTcnOpeninvoiceapplySubmitResponse.
    /// </summary>
    public class AlipayCommerceEcTcnOpeninvoiceapplySubmitResponse : AopResponse
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
