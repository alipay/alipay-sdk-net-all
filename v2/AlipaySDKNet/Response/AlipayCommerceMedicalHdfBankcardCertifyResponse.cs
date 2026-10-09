using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfBankcardCertifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfBankcardCertifyResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
