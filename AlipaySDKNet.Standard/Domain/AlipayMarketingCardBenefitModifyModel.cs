using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardBenefitModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardBenefitModifyModel : AopObject
    {
        /// <summary>
        /// 权益ID，通过 <a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create">alipay.marketing.card.benefit.create</a>(会员卡模板外部权益创建)接口创建获取。
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 会员卡模板外部权益
        /// </summary>
        [XmlElement("mcard_template_benefit")]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }
    }
}
