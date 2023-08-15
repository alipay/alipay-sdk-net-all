using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseTaskApplyResponse : AopResponse
    {
        /// <summary>
        /// 开始执行任务结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
