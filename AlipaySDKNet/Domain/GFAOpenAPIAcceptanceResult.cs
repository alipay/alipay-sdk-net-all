using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIAcceptanceResult Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIAcceptanceResult : AopObject
    {
        /// <summary>
        /// 受理单id
        /// </summary>
        [XmlElement("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 接口调用失败是否需要重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 接口结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 接口调用结果描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 解决方案id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }
    }
}
