using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmEquityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HmEquityInfo : AopObject
    {
        /// <summary>
        /// 是否激活
        /// </summary>
        [XmlElement("activated")]
        public bool Activated { get; set; }

        /// <summary>
        /// 权益包下的基础权益
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 权益包下的基础权益名称
        /// </summary>
        [XmlElement("equity_name")]
        public string EquityName { get; set; }

        /// <summary>
        /// 权益的计费类型
        /// </summary>
        [XmlElement("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 总额度-已使用额度，初始化=总额度，如果是金额：单位（分），如果是次数：单位（次）...
        /// </summary>
        [XmlElement("residue_quota")]
        public string ResidueQuota { get; set; }

        /// <summary>
        /// 权益包中配置的权益额度，如果是金额：单位（分），如果是次数：单位（次）...
        /// </summary>
        [XmlElement("total_quota")]
        public string TotalQuota { get; set; }

        /// <summary>
        /// 有效期结束时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
