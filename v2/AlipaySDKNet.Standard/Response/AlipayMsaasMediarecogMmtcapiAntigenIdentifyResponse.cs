using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcapiAntigenIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcapiAntigenIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 算法返回结果，json字符串，无敏感信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
