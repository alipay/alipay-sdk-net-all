using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspGroupclearQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspGroupclearQueryModel : AopObject
    {
        /// <summary>
        /// 清库任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
