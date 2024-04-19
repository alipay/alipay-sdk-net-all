using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentCancelResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentCancelResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
