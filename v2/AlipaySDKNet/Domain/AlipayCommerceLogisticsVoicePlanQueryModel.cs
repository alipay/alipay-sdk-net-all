using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsVoicePlanQueryModel : AopObject
    {
        /// <summary>
        /// 投放计划ID
        /// </summary>
        [XmlElement("logistics_voice_plan_id")]
        public string LogisticsVoicePlanId { get; set; }
    }
}
