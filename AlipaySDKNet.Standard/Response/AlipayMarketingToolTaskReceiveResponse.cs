using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolTaskReceiveResponse.
    /// </summary>
    public class AlipayMarketingToolTaskReceiveResponse : AopResponse
    {
        /// <summary>
        /// 阶段码。applet_signup任务报名。
        /// </summary>
        [XmlElement("stage_code")]
        public string StageCode { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
