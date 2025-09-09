using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsurancePayRefundResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsurancePayRefundResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
