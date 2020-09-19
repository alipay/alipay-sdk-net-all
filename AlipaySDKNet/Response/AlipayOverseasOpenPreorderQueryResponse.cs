using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// payment_info
        /// </summary>
        [XmlElement("payment_info")]
        public TuitionISVResponsePaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 预缴费单据号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 留学汇款对isv返回结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// TuitionISVStudentInfoDTO
        /// </summary>
        [XmlElement("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
