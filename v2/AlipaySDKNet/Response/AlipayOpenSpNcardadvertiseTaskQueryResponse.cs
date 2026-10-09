using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcardadvertiseTaskQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcardadvertiseTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 线圈作业单列表
        /// </summary>
        [XmlArray("task_list")]
        [XmlArrayItem("n_card_advertise_task")]
        public List<NCardAdvertiseTask> TaskList { get; set; }
    }
}
