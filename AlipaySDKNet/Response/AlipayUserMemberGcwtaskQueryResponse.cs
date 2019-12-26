using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberGcwtaskQueryResponse.
    /// </summary>
    public class AlipayUserMemberGcwtaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果码，如果失败会返回失败的结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 广场舞大赛任务（做任务领票数）
        /// </summary>
        [XmlArray("square_dance_task_info_list")]
        [XmlArrayItem("square_dance_task_info")]
        public List<SquareDanceTaskInfo> SquareDanceTaskInfoList { get; set; }

        /// <summary>
        /// true推进任务成功，false推进任务失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
