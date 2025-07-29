using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteSelectionTask Data Structure.
    /// </summary>
    [Serializable]
    public class SiteSelectionTask : AopObject
    {
        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 数据下载链接地址；当状态为SUCCESS时，url为空表示无数据返回
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 计算任务编码
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 数据计算任务模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
