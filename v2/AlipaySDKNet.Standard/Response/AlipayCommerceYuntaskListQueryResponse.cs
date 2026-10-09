using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskListQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskListQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务模版列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("yun_task_template_info_d_t_o")]
        public List<YunTaskTemplateInfoDTO> TaskList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
