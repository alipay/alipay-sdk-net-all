using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsCloudjobstatusQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsCloudjobstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 上云任务失败时给出的任务错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 上云任务状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
