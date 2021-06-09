using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizActionComsumedAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizActionComsumedAmountDTO : AopObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 外部系统bizUkId
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 占用金额
        /// </summary>
        [XmlElement("consumed_amount")]
        public string ConsumedAmount { get; set; }
    }
}
