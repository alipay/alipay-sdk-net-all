using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyInvUploadResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyInvUploadResponse : AopResponse
    {
        /// <summary>
        /// 处理是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
