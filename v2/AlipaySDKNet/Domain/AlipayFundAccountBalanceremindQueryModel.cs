using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountBalanceremindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBalanceremindQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，固定传：QUERY_PLAN
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 产品码，固定传：BALANCE_REMIND
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
