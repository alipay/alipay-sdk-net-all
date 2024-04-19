using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcapiDriverlicenseIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcapiDriverlicenseIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
