using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议支付id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 当前任务状态: not_exist , processing , success , failed
        /// </summary>
        [XmlElement("current_status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }
    }
}
