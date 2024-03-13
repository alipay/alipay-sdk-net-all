using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardQueryModel : AopObject
    {
        /// <summary>
        /// 用户信息 填写则作为附加条件查询
        /// </summary>
        [XmlElement("card_user_info")]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        /// 扩展信息，暂时没有
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作卡号。 若target_card_no_type为  BIZ_CARD，则该值为业务卡号，即alipay.marketing.card.open(会员卡开卡)返回结果中的card_info#biz_card_no。 若target_card_no_type为 D_QR_CODE 或D_BAR_CODE，则该值为动态码值。 若target_card_no_type为 EXTERNAL_CARD，则该值为外部卡号。
        /// </summary>
        [XmlElement("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型
        /// </summary>
        [XmlElement("target_card_no_type")]
        public string TargetCardNoType { get; set; }

        /// <summary>
        /// 会员卡模板id。调用<a href="https://opendocs.alipay.com/open/03sx80?scene=common&pathHash=04270a28" target="_blank">alipay.marketing.card.template.create</a>（会员卡模板创建接口）创建模板后同步返回。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
