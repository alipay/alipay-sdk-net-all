using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GbApplyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class GbApplyRequest : AopObject
    {
        /// <summary>
        /// 申请金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务单据名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务单据唯一id
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 预算适用类型 RESOURCE、ZK_COMMISSION
        /// </summary>
        [XmlElement("budget_use_type")]
        public string BudgetUseType { get; set; }

        /// <summary>
        /// 申请金额币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 集团预算编码
        /// </summary>
        [XmlElement("group_budget_code")]
        public string GroupBudgetCode { get; set; }

        /// <summary>
        /// 是否含税，true表示含税，false表示不含税，默认为true
        /// </summary>
        [XmlElement("tax_included")]
        public string TaxIncluded { get; set; }
    }
}
