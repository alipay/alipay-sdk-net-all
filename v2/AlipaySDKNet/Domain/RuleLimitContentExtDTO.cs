using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleLimitContentExtDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RuleLimitContentExtDTO : AopObject
    {
        /// <summary>
        /// 门店编号类型，real_shop_no：外部系统门店编号，real_shop_id：支付宝侧内部物理门店编号
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 外部或内部门店编号
        /// </summary>
        [XmlElement("limit_value")]
        public string LimitValue { get; set; }

        /// <summary>
        /// 限制对象的具体信息输出 如门店信息
        /// </summary>
        [XmlElement("rule_limit_shop_content")]
        public RuleLimitShopContentDTO RuleLimitShopContent { get; set; }
    }
}
