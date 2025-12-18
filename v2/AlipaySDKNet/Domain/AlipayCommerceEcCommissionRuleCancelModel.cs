using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCommissionRuleCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCommissionRuleCancelModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// 抽佣规则id，用于取消指定的抽佣规则； 通过查询门店配置的抽佣规则获取。
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
