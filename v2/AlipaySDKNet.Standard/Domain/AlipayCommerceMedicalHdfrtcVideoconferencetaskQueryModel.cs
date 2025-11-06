using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferencetaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferencetaskQueryModel : AopObject
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
