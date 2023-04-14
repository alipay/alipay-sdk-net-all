using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingAuthorizedData Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingAuthorizedData : AopObject
    {
        /// <summary>
        /// 营销活动ID，当type=PROMO_ACTIVITY即授权业务类别为营销活动时该值必填 限制: 1.当前只支持B、P站或openapi创建的支付券或商家券活动 2.部分通过报名招商方案创建的活动不支持授权给其他合作方。 3.活动的创建服务商和归属商户都可以调用接口发起授权  商家券文档:https://open.alipay.com/api/detail?abilityCode=AM010501000000089657 支付券:https://market.alipay.com/page.htm?_cpage=activity
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 授权业务类别，枚举值： PROMO_ACTIVITY:营销活动
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
