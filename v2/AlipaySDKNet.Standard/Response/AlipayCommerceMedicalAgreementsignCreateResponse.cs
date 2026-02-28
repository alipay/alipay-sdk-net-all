using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAgreementsignCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalAgreementsignCreateResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
