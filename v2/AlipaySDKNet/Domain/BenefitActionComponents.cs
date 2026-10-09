using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitActionComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitActionComponents : AopObject
    {
        /// <summary>
        /// 权益发奖行为组件
        /// </summary>
        [XmlElement("luck_draw_action_component")]
        public BenefitActionComponent LuckDrawActionComponent { get; set; }
    }
}
