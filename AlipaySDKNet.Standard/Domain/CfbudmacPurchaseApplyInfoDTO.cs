using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CfbudmacPurchaseApplyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CfbudmacPurchaseApplyInfoDTO : AopObject
    {
        /// <summary>
        /// 开始周期
        /// </summary>
        [XmlElement("begin_cycle")]
        public string BeginCycle { get; set; }

        /// <summary>
        /// bba编码
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 活动预算id
        /// </summary>
        [XmlElement("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 业务类型 PURCHASE("PURCHASE", "采购")
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// PERCENTAGE("PERCENTAGE", "出资占比"), ORDER("ORDER", "自定义顺序");
        /// </summary>
        [XmlElement("budget_strategy")]
        public string BudgetStrategy { get; set; }

        /// <summary>
        /// 币种，默认156
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 结束周期
        /// </summary>
        [XmlElement("end_cycle")]
        public string EndCycle { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 申请id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 预算池编码
        /// </summary>
        [XmlElement("pool_code")]
        public string PoolCode { get; set; }

        /// <summary>
        /// 剩余可用金额
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// 状态：CONFIG，CONFIG_DONE，CHECK，ACTIVE，HISTORY，CLOSE，DISCARD，INACTIVE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
