using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimreportModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceClaimreportModifyResponse : AopResponse
    {
        /// <summary>
        /// 回传成功标识
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
