using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUserSignResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceUserSignResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
