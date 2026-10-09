using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntarchiveFaceIdentifyResponse.
    /// </summary>
    public class AlipayUserAntarchiveFaceIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 比对分值
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
