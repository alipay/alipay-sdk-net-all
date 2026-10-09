using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinTaskDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinTaskDeleteModel : AopObject
    {
        /// <summary>
        /// 任务code
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
