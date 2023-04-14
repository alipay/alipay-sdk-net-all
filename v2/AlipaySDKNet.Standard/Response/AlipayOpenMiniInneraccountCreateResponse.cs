using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
