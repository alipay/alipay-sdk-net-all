using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentNotifyResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentNotifyResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
