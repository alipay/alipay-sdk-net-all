using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommissionRuleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommissionRuleCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// 被抽佣支付宝的登录号，用于出资的账号。用户录入。
        /// </summary>
        [XmlElement("charged_account_login_id")]
        public string ChargedAccountLoginId { get; set; }

        /// <summary>
        /// 被抽佣支付宝账号名称。
        /// </summary>
        [XmlElement("charged_account_name")]
        public string ChargedAccountName { get; set; }

        /// <summary>
        /// 抽佣比例，格式为小数如0.1
        /// </summary>
        [XmlElement("commission_ratio")]
        public string CommissionRatio { get; set; }

        /// <summary>
        /// 抽佣结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 抽佣开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
