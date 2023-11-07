using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCardTemplateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCardTemplateModifyModel : AopObject
    {
        /// <summary>
        /// 卡模版信息
        /// </summary>
        [XmlElement("card_template_info")]
        public CardTemplateInfo CardTemplateInfo { get; set; }
    }
}
