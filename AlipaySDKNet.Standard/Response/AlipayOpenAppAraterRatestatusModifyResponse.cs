using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppAraterRatestatusModifyResponse.
    /// </summary>
    public class AlipayOpenAppAraterRatestatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否更惨成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
