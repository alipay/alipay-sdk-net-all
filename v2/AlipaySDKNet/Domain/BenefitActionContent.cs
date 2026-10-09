using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitActionContent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitActionContent : AopObject
    {
        /// <summary>
        /// 权益发奖信息
        /// </summary>
        [XmlElement("luck_draw_info")]
        public BenefitLuckDrawInfo LuckDrawInfo { get; set; }
    }
}
