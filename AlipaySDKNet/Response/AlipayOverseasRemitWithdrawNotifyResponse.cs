using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasRemitWithdrawNotifyResponse.
    /// </summary>
    public class AlipayOverseasRemitWithdrawNotifyResponse : AopResponse
    {
        /// <summary>
        /// JSON map
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
