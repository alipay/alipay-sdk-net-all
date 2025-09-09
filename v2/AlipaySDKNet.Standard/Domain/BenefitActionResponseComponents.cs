using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitActionResponseComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitActionResponseComponents : AopObject
    {
        /// <summary>
        /// 权益发奖行为组件
        /// </summary>
        [XmlElement("luck_draw_action_component")]
        public BenefitActionResponseComponent LuckDrawActionComponent { get; set; }
    }
}
