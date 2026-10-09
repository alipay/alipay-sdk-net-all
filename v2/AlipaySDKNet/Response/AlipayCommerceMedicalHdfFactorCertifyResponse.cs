using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfFactorCertifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfFactorCertifyResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
