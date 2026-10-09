using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseDataserviceInsighttaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseDataserviceInsighttaskQueryModel : AopObject
    {
        /// <summary>
        /// 给客户发放的调用ID
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }

        /// <summary>
        /// 洞察任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
