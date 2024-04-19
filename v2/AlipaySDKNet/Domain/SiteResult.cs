using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteResult Data Structure.
    /// </summary>
    [Serializable]
    public class SiteResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("site_item")]
        public List<SiteItem> Data { get; set; }

        /// <summary>
        /// 返回消息提示
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务结果列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("site_plan_item")]
        public List<SitePlanItem> TaskList { get; set; }
    }
}
