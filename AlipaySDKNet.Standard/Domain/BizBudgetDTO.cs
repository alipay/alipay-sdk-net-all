using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizBudgetDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizBudgetDTO : AopObject
    {
        /// <summary>
        /// 预算业务申请信息
        /// </summary>
        [XmlArray("biz_apply_info")]
        [XmlArrayItem("purchase_apply_info_d_t_o")]
        public List<PurchaseApplyInfoDTO> BizApplyInfo { get; set; }

        /// <summary>
        /// 活动预算编码
        /// </summary>
        [XmlElement("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 活动预算的名称，非用户名，不是敏感字段
        /// </summary>
        [XmlElement("biz_budget_name")]
        public string BizBudgetName { get; set; }
    }
}
