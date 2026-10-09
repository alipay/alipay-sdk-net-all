using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiRpacrawlerQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiRpacrawlerQueryResponse : AopResponse
    {
        /// <summary>
        /// RPA任务
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("rpa_crawler_task_v_o")]
        public List<RpaCrawlerTaskVO> TaskList { get; set; }

        /// <summary>
        /// 任务统计总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
