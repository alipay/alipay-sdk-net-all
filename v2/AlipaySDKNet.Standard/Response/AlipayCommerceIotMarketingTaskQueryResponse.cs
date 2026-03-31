using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingTaskQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("pages")]
        public long Pages { get; set; }

        /// <summary>
        /// 任务信息列表
        /// </summary>
        [XmlArray("task_info_list")]
        [XmlArrayItem("i_s_p_task_info")]
        public List<ISPTaskInfo> TaskInfoList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
