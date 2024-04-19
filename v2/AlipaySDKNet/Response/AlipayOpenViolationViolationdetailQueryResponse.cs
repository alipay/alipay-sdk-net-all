using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenViolationViolationdetailQueryResponse.
    /// </summary>
    public class AlipayOpenViolationViolationdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 申诉截止日期。 即商户可进行申诉的截止日期，若超过该时间未申诉或申诉不通过，平台不提供申诉机会，维持原处罚结果；若该时间内完成申诉且申诉通过，平台将撤销对商户的处罚
        /// </summary>
        [XmlElement("appeal_dead_line")]
        public string AppealDeadLine { get; set; }

        /// <summary>
        /// 商家申诉记录
        /// </summary>
        [XmlArray("appeal_reply_records")]
        [XmlArrayItem("reply_record")]
        public List<ReplyRecord> AppealReplyRecords { get; set; }

        /// <summary>
        /// 商家是否可以申诉
        /// </summary>
        [XmlElement("can_appeal")]
        public bool CanAppeal { get; set; }

        /// <summary>
        /// 商家是否可以整改
        /// </summary>
        [XmlElement("can_rectify")]
        public bool CanRectify { get; set; }

        /// <summary>
        /// 处罚动作及有效期
        /// </summary>
        [XmlArray("punish_action")]
        [XmlArrayItem("string")]
        public List<string> PunishAction { get; set; }

        /// <summary>
        /// 截止整改时间。即商户可进行整改的截止日期，若超过该时间未整改或整改不通过，平台将对商户进行处罚，若该时间内完成整改且整改通过，平台对商户不处罚
        /// </summary>
        [XmlElement("rectify_dead_line")]
        public string RectifyDeadLine { get; set; }

        /// <summary>
        /// 商家整改记录
        /// </summary>
        [XmlArray("rectify_reply_records")]
        [XmlArrayItem("reply_record")]
        public List<ReplyRecord> RectifyReplyRecords { get; set; }

        /// <summary>
        /// 违规工单状态枚举
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 剩余申诉次数。 即在申诉截止日期内，平台允许商家申诉的次数，当商户提交申诉但申诉未通过时，剩余申诉次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚
        /// </summary>
        [XmlElement("surplus_appeal_cnt")]
        public string SurplusAppealCnt { get; set; }

        /// <summary>
        /// 剩余整改次数。即在整改截止日期内，平台允许商家整改的次数，当商户提交整改但整改未通过时，剩余整改次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚
        /// </summary>
        [XmlElement("surplus_rectify_cnt")]
        public string SurplusRectifyCnt { get; set; }

        /// <summary>
        /// 违规对象ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 违规对象名称
        /// </summary>
        [XmlElement("target_name")]
        public string TargetName { get; set; }

        /// <summary>
        /// 违规对象类型 小程序ID:APPID 生活号ID:PUBLICID
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 平台判定商家违规凭证
        /// </summary>
        [XmlArray("violation_evidence")]
        [XmlArrayItem("audit_evidence_info")]
        public List<AuditEvidenceInfo> ViolationEvidence { get; set; }

        /// <summary>
        /// 违规原因
        /// </summary>
        [XmlElement("violation_reason")]
        public string ViolationReason { get; set; }

        /// <summary>
        /// 支付宝侧生成的违规记录唯一标识
        /// </summary>
        [XmlElement("violation_record_id")]
        public string ViolationRecordId { get; set; }

        /// <summary>
        /// 违规时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("violation_time")]
        public string ViolationTime { get; set; }

        /// <summary>
        /// 即平台依据平台规范/规则，判定商户的违规类型
        /// </summary>
        [XmlElement("violation_type")]
        public string ViolationType { get; set; }
    }
}
