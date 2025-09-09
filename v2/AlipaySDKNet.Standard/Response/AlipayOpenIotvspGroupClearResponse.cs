using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspGroupClearResponse.
    /// </summary>
    public class AlipayOpenIotvspGroupClearResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧生成的清库任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
