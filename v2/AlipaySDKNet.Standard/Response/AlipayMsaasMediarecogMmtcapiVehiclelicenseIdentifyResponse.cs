using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcapiVehiclelicenseIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcapiVehiclelicenseIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
