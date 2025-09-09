using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitQueryComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryComponents : AopObject
    {
        /// <summary>
        /// 权益召回组件
        /// </summary>
        [XmlElement("luck_draw_query_component")]
        public BenefitQueryComponent LuckDrawQueryComponent { get; set; }
    }
}
