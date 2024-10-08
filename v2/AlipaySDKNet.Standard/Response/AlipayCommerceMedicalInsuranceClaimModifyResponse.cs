using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceClaimModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
