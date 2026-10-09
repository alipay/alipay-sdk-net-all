using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdBudgetassignModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdBudgetassignModifyModel : AopObject
    {
        /// <summary>
        /// 后付金额，单位：元，支持两位小数
        /// </summary>
        [XmlElement("after_principal_amount_yuan")]
        public string AfterPrincipalAmountYuan { get; set; }

        /// <summary>
        /// 登录用户支付宝统一ID,2088开头字符串。登录校验和可反查出user_id。
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 划拨金额，单位：元，支持两位小数
        /// </summary>
        [XmlElement("amount_yuan")]
        public string AmountYuan { get; set; }

        /// <summary>
        /// 划拨模式： "CUSTOM" - 自定义分配，该模式下，根据marketing_amount_yuan, benefit_amount, after_principal_amount_yuan, principal_amount_yuan分配。 "AUTO" - 自动分配，该模式下根据入参amount_yuan自动分配金额
        /// </summary>
        [XmlElement("assign_mod")]
        public string AssignMod { get; set; }

        /// <summary>
        /// 权益金额，单位：元，支持两位小数
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 划拨场景编码目前固定：INTELLIGENT- 通用钱包
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 权限token,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 营销金额，单位：元，支持两位小数
        /// </summary>
        [XmlElement("marketing_amount_yuan")]
        public string MarketingAmountYuan { get; set; }

        /// <summary>
        /// 现金金额，单位：元，支持两位小数
        /// </summary>
        [XmlElement("principal_amount_yuan")]
        public string PrincipalAmountYuan { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
