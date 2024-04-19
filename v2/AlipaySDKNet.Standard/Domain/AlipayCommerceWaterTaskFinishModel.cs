using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterTaskFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterTaskFinishModel : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
