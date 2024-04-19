using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTcnInvoiceapplyModifyResponse.
    /// </summary>
    public class AlipayCommerceEcTcnInvoiceapplyModifyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 开票申请状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }
    }
}
