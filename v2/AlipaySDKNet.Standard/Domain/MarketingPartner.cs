using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingPartner Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingPartner : AopObject
    {
        /// <summary>
        /// 行业合作方案ID，合作方类别为INDUSTRY_PLAN时必传。 暂未开放
        /// </summary>
        [XmlElement("industry_plan_id")]
        public string IndustryPlanId { get; set; }

        /// <summary>
        /// 合作方商户ID，合作方类别为MERCHANT时必填。 限制: 1.当前只支持直连商户
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 合作方APPID，合作方类别为APPID时必填。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 合作方类别，枚举值： APPID：合作方为APPID MERCHANT：合作方为商户 NDUSTRY_PLAN:行业合作方案(暂未开放)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
