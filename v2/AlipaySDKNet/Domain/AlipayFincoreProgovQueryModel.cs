using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreProgovQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreProgovQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁资产接入工单任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
