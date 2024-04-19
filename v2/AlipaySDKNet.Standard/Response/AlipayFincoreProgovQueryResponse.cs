using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreProgovQueryResponse.
    /// </summary>
    public class AlipayFincoreProgovQueryResponse : AopResponse
    {
        /// <summary>
        /// 工单当前状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
