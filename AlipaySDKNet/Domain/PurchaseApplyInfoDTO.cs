using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseApplyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseApplyInfoDTO : AopObject
    {
        /// <summary>
        /// 采购类目
        /// </summary>
        [XmlElement("account_code")]
        public string AccountCode { get; set; }

        /// <summary>
        /// 预算周期
        /// </summary>
        [XmlElement("begin_cycle")]
        public string BeginCycle { get; set; }

        /// <summary>
        /// 活动预算申请code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 活动预算id
        /// </summary>
        [XmlElement("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 业务类型 COMMISSION("COMMISSION", "返佣"), PURCHASE("PURCHASE", "采购"), PROMO("PROMO", "营销"),
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// PERCENTAGE("PERCENTAGE", "出资占比"), ORDER("ORDER", "自定义顺序");
        /// </summary>
        [XmlElement("budget_strategy")]
        public string BudgetStrategy { get; set; }

        /// <summary>
        /// 预算周期结束时间
        /// </summary>
        [XmlElement("end_cycle")]
        public string EndCycle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 申请id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动预算池编码
        /// </summary>
        [XmlElement("pool_code")]
        public string PoolCode { get; set; }

        /// <summary>
        /// 状态：CONFIG，CONFIG_DONE，CHECK，ACTIVE，HISTORY，CLOSE，DISCARD，INACTIVE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 采购用途
        /// </summary>
        [XmlElement("use")]
        public string Use { get; set; }
    }
}
