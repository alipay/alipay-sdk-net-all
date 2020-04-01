using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractManagerProcessSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ContractManagerProcessSyncRequest : AopObject
    {
        /// <summary>
        /// 签署文档内容摘要
        /// </summary>
        [XmlElement("abstract_content")]
        public string AbstractContent { get; set; }

        /// <summary>
        /// 流程附件
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("contract_manager_attachments_syncrequest")]
        public List<ContractManagerAttachmentsSyncrequest> Attachments { get; set; }

        /// <summary>
        /// 流程主题
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 合同截止时间（从签署文档中分析得到的数据）
        /// </summary>
        [XmlElement("contract_deadline_time")]
        public string ContractDeadlineTime { get; set; }

        /// <summary>
        /// 流程结束时间
        /// </summary>
        [XmlElement("flow_end_time")]
        public string FlowEndTime { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 流程开始时间(时间戳)
        /// </summary>
        [XmlElement("flow_start_time")]
        public string FlowStartTime { get; set; }

        /// <summary>
        /// 签署状态 0-草稿 1-签署中 2-完成 3-撤销 4-终止 5-过期 6-删除 7-拒签
        /// </summary>
        [XmlElement("flow_status")]
        public string FlowStatus { get; set; }

        /// <summary>
        /// 0-正式合同 1-活动文件(运营类活动文件 如情人节活动、防疫公约)
        /// </summary>
        [XmlElement("flow_type")]
        public string FlowType { get; set; }

        /// <summary>
        /// 商家Id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 参与人信息
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("contract_manager_participants_sync_request")]
        public List<ContractManagerParticipantsSyncRequest> Participants { get; set; }

        /// <summary>
        /// 签署合同的截止时间
        /// </summary>
        [XmlElement("sign_deadline_time")]
        public string SignDeadlineTime { get; set; }

        /// <summary>
        /// 签署文档
        /// </summary>
        [XmlArray("sign_docs")]
        [XmlArrayItem("contract_manager_sign_docs_request")]
        public List<ContractManagerSignDocsRequest> SignDocs { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
