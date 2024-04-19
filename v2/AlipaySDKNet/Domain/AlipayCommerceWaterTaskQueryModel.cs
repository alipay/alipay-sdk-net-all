using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterTaskQueryModel : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
