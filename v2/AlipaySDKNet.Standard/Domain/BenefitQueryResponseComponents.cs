using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitQueryResponseComponents Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryResponseComponents : AopObject
    {
        /// <summary>
        /// 权益召回组件
        /// </summary>
        [XmlElement("luck_draw_query_component")]
        public BenefitQueryResponseComponent LuckDrawQueryComponent { get; set; }
    }
}
