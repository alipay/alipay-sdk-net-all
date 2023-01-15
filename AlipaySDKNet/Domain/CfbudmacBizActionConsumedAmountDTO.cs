using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CfbudmacBizActionConsumedAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CfbudmacBizActionConsumedAmountDTO : AopObject
    {
        /// <summary>
        /// 业务预算申请code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 占用金额，单位元
        /// </summary>
        [XmlElement("consumed_amount")]
        public string ConsumedAmount { get; set; }

        /// <summary>
        /// 占用金额币种
        /// </summary>
        [XmlElement("consumed_amount_currency")]
        public string ConsumedAmountCurrency { get; set; }
    }
}
