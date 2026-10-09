using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceBillMsgApplyResponse.
    /// </summary>
    public class AlipayCommerceBillMsgApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
