using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayCompensateDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayCompensateDetailVO : AopObject
    {
        /// <summary>
        /// 费用列表
        /// </summary>
        [XmlArray("charge_pricing_list")]
        [XmlArrayItem("credit_pay_charge_pricing_v_o")]
        public List<CreditPayChargePricingVO> ChargePricingList { get; set; }

        /// <summary>
        /// 条款视图列表
        /// </summary>
        [XmlArray("clauses")]
        [XmlArrayItem("credit_pay_clause_v_o")]
        public List<CreditPayClauseVO> Clauses { get; set; }

        /// <summary>
        /// 分期间隔
        /// </summary>
        [XmlElement("instal_itrv")]
        public string InstalItrv { get; set; }

        /// <summary>
        /// 分期类型(D-日，M-月，Y-年)
        /// </summary>
        [XmlElement("instal_type")]
        public string InstalType { get; set; }

        /// <summary>
        /// 利息定价
        /// </summary>
        [XmlElement("int_pricing")]
        public CreditPayIntPricingVO IntPricing { get; set; }
    }
}
