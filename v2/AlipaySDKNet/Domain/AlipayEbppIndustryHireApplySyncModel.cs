using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryHireApplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryHireApplySyncModel : AopObject
    {
        /// <summary>
        /// 用户投递ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报名状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 报名状态详细说明，相当于备注
        /// </summary>
        [XmlElement("detail_reason")]
        public string DetailReason { get; set; }

        /// <summary>
        /// 不合适原因
        /// </summary>
        [XmlElement("inappropriate_reason")]
        public string InappropriateReason { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 报名状态更新操作时间 如果报名状态有变更，通过本接口传更新后的信息。
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 流程异常原因
        /// </summary>
        [XmlElement("process_exception_reason")]
        public string ProcessExceptionReason { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
