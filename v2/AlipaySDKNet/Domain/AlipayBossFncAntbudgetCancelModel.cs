using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAntbudgetCancelModel : AopObject
    {
        /// <summary>
        /// 业务预算申请code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// * COMMISSION: 返佣 * PURCHASE: 采购 * PROMO: 营销
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务活动唯一id,用于幂等,与biz_type一起组成幂等索引，不可重复
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }
    }
}
