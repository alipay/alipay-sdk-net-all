using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCreateModel : AopObject
    {
        /// <summary>
        /// 复杂类型，参见AdPlan定义
        /// </summary>
        [XmlElement("ad_plan")]
        public AdPlan AdPlan { get; set; }
    }
}
