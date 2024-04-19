using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterUsertaskdetailQueryModel : AopObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户任务id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }
    }
}
