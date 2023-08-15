using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseDatabaseTaskGetModel : AopObject
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
        /// 列表数据排序
        /// </summary>
        [XmlElement("desc")]
        public bool Desc { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务的一个序号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlArray("task_types")]
        [XmlArrayItem("string")]
        public List<string> TaskTypes { get; set; }
    }
}
