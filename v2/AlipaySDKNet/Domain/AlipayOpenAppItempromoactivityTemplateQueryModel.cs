using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItempromoactivityTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }
    }
}
