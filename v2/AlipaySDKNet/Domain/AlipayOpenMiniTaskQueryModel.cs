using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTaskQueryModel : AopObject
    {
        /// <summary>
        /// 生图任务的任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
