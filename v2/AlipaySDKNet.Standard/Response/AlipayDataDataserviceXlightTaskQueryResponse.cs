using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceXlightTaskQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceXlightTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 任务完成状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
