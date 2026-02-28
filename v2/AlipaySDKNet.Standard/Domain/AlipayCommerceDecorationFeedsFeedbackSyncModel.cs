using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDecorationFeedsFeedbackSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDecorationFeedsFeedbackSyncModel : AopObject
    {
        /// <summary>
        /// 线索分配给对应装企的原因
        /// </summary>
        [XmlElement("assign_reason")]
        public string AssignReason { get; set; }

        /// <summary>
        /// 装企id，装企唯一标识符，支付宝侧生成（请传递数字类型的字符串）
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("company_ids")]
        [XmlArrayItem("string")]
        public List<string> CompanyIds { get; set; }

        /// <summary>
        /// 装修企业名称 当前字段已废弃(线索平台会根据装企ID去匹配上装企名称，该字段传递了也不会用到。)
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 反馈类型
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }

        /// <summary>
        /// 线索id，线索唯一标识符，支付宝侧生成
        /// </summary>
        [XmlElement("lead_id")]
        public string LeadId { get; set; }

        /// <summary>
        /// 服务商id，服务商唯一标识符，支付宝侧生成 当前字段已废弃(线索ID会绑定上服务商ID，线索平台会使用线索ID绑定的服务商ID。这边传递服务商ID不会有任何作用。)
        /// </summary>
        [XmlElement("provider_id")]
        public string ProviderId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 线索状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 线索是否有效
        /// </summary>
        [XmlElement("valid")]
        public string Valid { get; set; }
    }
}
