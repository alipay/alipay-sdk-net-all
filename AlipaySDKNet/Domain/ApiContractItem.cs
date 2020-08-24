using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiContractItem Data Structure.
    /// </summary>
    [Serializable]
    public class ApiContractItem : AopObject
    {
        /// <summary>
        /// 实际逾期时间
        /// </summary>
        [XmlElement("actual_due_time")]
        public string ActualDueTime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 逾期时间
        /// </summary>
        [XmlElement("due_time")]
        public string DueTime { get; set; }

        /// <summary>
        /// 事项目标
        /// </summary>
        [XmlArray("goals")]
        [XmlArrayItem("api_contract_goal")]
        public List<ApiContractGoal> Goals { get; set; }

        /// <summary>
        /// 事项号
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 事项期数
        /// </summary>
        [XmlElement("item_phase")]
        public string ItemPhase { get; set; }

        /// <summary>
        /// PENDING_COMPLETE、COMPLETE、UNDONE、CLOSE
        /// </summary>
        [XmlElement("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 每一期事项下的次数
        /// </summary>
        [XmlElement("phase_serial_num")]
        public string PhaseSerialNum { get; set; }

        /// <summary>
        /// 模版号
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
