using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoravatarinfoCopyResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctoravatarinfoCopyResponse : AopResponse
    {
        /// <summary>
        /// 医生头像同步任务id
        /// </summary>
        [XmlElement("pic_sync_task_id")]
        public string PicSyncTaskId { get; set; }
    }
}
