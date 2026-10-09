using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHyInquiryorderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHyInquiryorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 退费流水号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
