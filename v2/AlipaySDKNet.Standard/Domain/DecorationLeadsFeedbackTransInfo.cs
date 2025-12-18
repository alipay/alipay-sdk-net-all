using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DecorationLeadsFeedbackTransInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DecorationLeadsFeedbackTransInfo : AopObject
    {
        /// <summary>
        /// 与客户签订的合同编号，便于后续追踪
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 实际成交的时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 当前成交状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
