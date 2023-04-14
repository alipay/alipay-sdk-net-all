using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardActivateurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardActivateurlQueryModel : AopObject
    {
        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
