using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsurequoteConsultResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceInsurequoteConsultResponse : AopResponse
    {
        /// <summary>
        /// 投保方案
        /// </summary>
        [XmlElement("insure_plan")]
        public InsurePlanDTO InsurePlan { get; set; }
    }
}
