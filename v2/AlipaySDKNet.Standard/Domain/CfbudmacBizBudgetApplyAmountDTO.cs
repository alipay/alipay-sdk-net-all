using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CfbudmacBizBudgetApplyAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CfbudmacBizBudgetApplyAmountDTO : AopObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// BBA全量占用金额，单位元
        /// </summary>
        [XmlElement("consumed_amount")]
        public string ConsumedAmount { get; set; }

        /// <summary>
        /// 占用金额币种
        /// </summary>
        [XmlElement("consumed_amount_currency")]
        public string ConsumedAmountCurrency { get; set; }

        /// <summary>
        /// BBA全量剩余金额，单位为元
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// 剩余金额币种
        /// </summary>
        [XmlElement("remain_amount_currency")]
        public string RemainAmountCurrency { get; set; }
    }
}
