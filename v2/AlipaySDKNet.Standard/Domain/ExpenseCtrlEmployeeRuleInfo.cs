using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseCtrlEmployeeRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseCtrlEmployeeRuleInfo : AopObject
    {
        /// <summary>
        /// 费控规则状态，1表示有效，0表示无效
        /// </summary>
        [XmlElement("effective")]
        public long Effective { get; set; }

        /// <summary>
        /// 费控规则有效期截止
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 费控规则有效期起始
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 费控规则作用范围， EMPLOYEE表示员工，ENTERPRISE表示企业
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 费控规则名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
