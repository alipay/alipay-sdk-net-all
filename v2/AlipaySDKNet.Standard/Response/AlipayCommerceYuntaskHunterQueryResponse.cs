using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskHunterQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskHunterQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        [XmlArray("task_info_list")]
        [XmlArrayItem("task_instance_basic_info")]
        public List<TaskInstanceBasicInfo> TaskInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
