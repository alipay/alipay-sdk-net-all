using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitQueryContent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryContent : AopObject
    {
        /// <summary>
        /// 权益召回模板集合
        /// </summary>
        [XmlArray("luck_draw_templates")]
        [XmlArrayItem("benefit_luck_draw_template")]
        public List<BenefitLuckDrawTemplate> LuckDrawTemplates { get; set; }
    }
}
