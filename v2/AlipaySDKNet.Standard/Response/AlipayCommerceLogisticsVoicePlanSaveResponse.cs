using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlanSaveResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoicePlanSaveResponse : AopResponse
    {
        /// <summary>
        /// 投放计划ID
        /// </summary>
        [XmlElement("logistics_voice_plan_id")]
        public string LogisticsVoicePlanId { get; set; }
    }
}
