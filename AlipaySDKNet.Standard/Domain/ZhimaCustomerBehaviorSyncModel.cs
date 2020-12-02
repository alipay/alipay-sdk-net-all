using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerBehaviorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerBehaviorSyncModel : AopObject
    {
        /// <summary>
        /// 反馈行为
        /// </summary>
        [XmlArray("behavior")]
        [XmlArrayItem("string")]
        public List<string> Behavior { get; set; }

        /// <summary>
        /// 行为所携带的内容,fulfillment:{"subjectDeltaNum":"1","subjectType":"subject"}
        /// </summary>
        [XmlElement("behavior_content")]
        public string BehaviorContent { get; set; }

        /// <summary>
        /// 约定编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 主体类型B或者C
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 芝麻信用service_id,由芝麻信用提供
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 芝麻信用service_id,由芝麻信用提供
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 外部订单号，商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
