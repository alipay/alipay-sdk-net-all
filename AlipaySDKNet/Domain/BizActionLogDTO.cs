using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizActionLogDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizActionLogDTO : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 预算活动id
        /// </summary>
        [XmlElement("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 业务活动名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// * 业务类型，      * COMMISSION: 返佣      * PURCHASE: 采购      * PROMO: 营销
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [XmlElement("biz_uk_id")]
        public string BizUkId { get; set; }

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
        /// 记录id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// BIZ_APPLY, 业务活动预算申请      *      *     BIZ_RETURN, 业务活动预算退回      *      *     BIZ_EXPIRE_RETURN, 业务活动预算过期退回
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }
    }
}
