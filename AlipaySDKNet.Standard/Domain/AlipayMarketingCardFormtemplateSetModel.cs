using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardFormtemplateSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardFormtemplateSetModel : AopObject
    {
        /// <summary>
        /// 会员卡开卡时的表单字段配置信息，即用户开卡时需填写内容。可定义多个通用表单字段，最大不超过20个。
        /// </summary>
        [XmlElement("fields")]
        public OpenFormFieldDO Fields { get; set; }

        /// <summary>
        /// 会员卡模板id。调用alipay.marketing.card.template.create（会员卡模板创建接口）创建模板后同步返回。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
