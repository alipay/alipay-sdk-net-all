using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAsaingameScheduleQueryResponse.
    /// </summary>
    public class AlipayUserAsaingameScheduleQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 业务是否处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 用户行程
        /// </summary>
        [XmlElement("user_schedule")]
        public OpenApiUserScheduleVO UserSchedule { get; set; }
    }
}
