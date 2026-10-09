using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAsaingameScheduleAddResponse.
    /// </summary>
    public class AlipayUserAsaingameScheduleAddResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 成功与否
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
