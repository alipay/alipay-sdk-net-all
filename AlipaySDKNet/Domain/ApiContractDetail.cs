using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiContractDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ApiContractDetail : AopObject
    {
        /// <summary>
        /// 合约取消时间
        /// </summary>
        [XmlElement("cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 合约完结时间
        /// </summary>
        [XmlElement("complete_date")]
        public string CompleteDate { get; set; }

        /// <summary>
        /// 合约事项列表
        /// </summary>
        [XmlArray("contract_items")]
        [XmlArrayItem("api_contract_item")]
        public List<ApiContractItem> ContractItems { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// INIT、EFFECT、COMPLETE、CLOSE、INVALID
        /// </summary>
        [XmlElement("contract_status")]
        public string ContractStatus { get; set; }

        /// <summary>
        /// APPLY_CANCEL、CANCEL_CONFIRM、CANCEL_FORCE、REFUSE、UNDONE
        /// </summary>
        [XmlElement("contract_sub_status")]
        public string ContractSubStatus { get; set; }

        /// <summary>
        /// 合约生效时间
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 约定失效时间
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 事项列表(废弃)
        /// </summary>
        [XmlElement("items")]
        public ApiContractItem Items { get; set; }

        /// <summary>
        /// 历史加入人次
        /// </summary>
        [XmlElement("join_history_people")]
        public long JoinHistoryPeople { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 发约主体id
        /// </summary>
        [XmlElement("offer_principal_id")]
        public string OfferPrincipalId { get; set; }

        /// <summary>
        /// 参与者列表
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("api_contract_participant")]
        public List<ApiContractParticipant> Participants { get; set; }

        /// <summary>
        /// 模版号
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
