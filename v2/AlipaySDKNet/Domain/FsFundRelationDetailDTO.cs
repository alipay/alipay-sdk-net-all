using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FsFundRelationDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FsFundRelationDetailDTO : AopObject
    {
        /// <summary>
        /// 出资金额是否允许上浮
        /// </summary>
        [XmlElement("allowed_float_up")]
        public bool AllowedFloatUp { get; set; }

        /// <summary>
        /// 当预算不足时允许跳过预算扣减
        /// </summary>
        [XmlElement("allows_skip_budget_deduction")]
        public bool AllowsSkipBudgetDeduction { get; set; }

        /// <summary>
        /// 封顶金额，单位元
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 优先级，按顺序出资时必填，值越小优先级越大
        /// </summary>
        [XmlElement("fund_priority")]
        public long FundPriority { get; set; }

        /// <summary>
        /// 平台出资
        /// </summary>
        [XmlElement("fund_provider")]
        public string FundProvider { get; set; }

        /// <summary>
        /// 出资比例，按比例出资时必填，值必须是小于等于100的整数，如出资比例33%，值为33
        /// </summary>
        [XmlElement("fund_ratio")]
        public long FundRatio { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 出资账号对应用户ID
        /// </summary>
        [XmlElement("fund_user_id")]
        public string FundUserId { get; set; }
    }
}
