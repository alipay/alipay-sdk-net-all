using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCardTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCardTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 卡模版信息
        /// </summary>
        [XmlElement("card_template_info")]
        public CardTemplateInfo CardTemplateInfo { get; set; }
    }
}
