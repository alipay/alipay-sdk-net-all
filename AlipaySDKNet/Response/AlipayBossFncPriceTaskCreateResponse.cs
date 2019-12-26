using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncPriceTaskCreateResponse.
    /// </summary>
    public class AlipayBossFncPriceTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 价格任务创建的返回结果
        /// </summary>
        [XmlElement("task_detail")]
        public string TaskDetail { get; set; }
    }
}
