using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalUsermessageSubscriptionQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalUsermessageSubscriptionQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户消息订阅信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("medical_user_message_subcription_info")]
        public List<MedicalUserMessageSubcriptionInfo> Data { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
