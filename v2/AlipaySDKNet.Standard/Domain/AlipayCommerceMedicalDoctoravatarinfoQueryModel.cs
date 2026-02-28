using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoravatarinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctoravatarinfoQueryModel : AopObject
    {
        /// <summary>
        /// 医生头像同步任务id
        /// </summary>
        [XmlElement("pic_sync_task_id")]
        public string PicSyncTaskId { get; set; }
    }
}
