using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntiepRightsSendResponse.
    /// </summary>
    public class AlipaySocialAntiepRightsSendResponse : AopResponse
    {
        /// <summary>
        /// 是否幂等
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }
    }
}
