using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 会员卡模板id。调用alipay.marketing.card.template.create（会员卡模板创建接口）创建模板后同步返回。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
