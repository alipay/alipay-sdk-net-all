using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceAihrInterviewReportBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceAihrInterviewReportBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ai_interview_id_list")]
        [XmlArrayItem("string")]
        public List<string> AiInterviewIdList { get; set; }

        /// <summary>
        /// 对应系统租户，用于校验是否和APPID对应租户一致
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
