using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountBalanceremindstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBalanceremindstatusModifyModel : AopObject
    {
        /// <summary>
        /// 场景码，固定传：MODIFY_PLAN_STATUS
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 计划版本号
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }

        /// <summary>
        /// 产品码，固定传：BALANCE_REMIND
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 计划状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
