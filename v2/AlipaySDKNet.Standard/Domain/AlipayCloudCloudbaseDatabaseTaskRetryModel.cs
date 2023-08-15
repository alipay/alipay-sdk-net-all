using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskRetryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseTaskRetryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 云数据库任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类型  - IMPORT  - EXPORT
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
