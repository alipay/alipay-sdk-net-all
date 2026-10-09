using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendResponse.
    /// </summary>
    public class AlipayEbppRechargeNotifySendResponse : AopResponse
    {
        /// <summary>
        /// 操作状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
