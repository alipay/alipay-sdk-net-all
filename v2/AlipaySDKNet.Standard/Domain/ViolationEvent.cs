using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ViolationEvent Data Structure.
    /// </summary>
    [Serializable]
    public class ViolationEvent : AopObject
    {
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
        [XmlElement("punish_action")]
        public string PunishAction { get; set; }

        /// <summary>
        /// 违规工单状态枚举： PUNISH_DONE：处罚生效中 PUNISH_APPEAL_REVOKED：处罚已撤销 PUNISH_INVALID_REVOKED：处罚已到期 WAITING_RECTIFY：待整改  RECTIFY_AUDITOR_PROCESSING：整改审核中 RECTIFY_REJECTED：整改不通过 RECTIFY_PASSED：整改通过 RECTIFY_TIMEOUT ：整改已超时
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

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
        /// 违规对象类型 小程序ID:APPID  生活号ID:PUBLICID
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 违规记录ID
        /// </summary>
        [XmlElement("violation_record_id")]
        public string ViolationRecordId { get; set; }

        /// <summary>
        /// 违规时间
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
