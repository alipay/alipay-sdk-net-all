using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpIsvSignauthQueryResponse.
    /// </summary>
    public class AlipayOpenSpIsvSignauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约授权一体化订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约授权一体化订单状态 INIT:初始化 UNCONFIRM:待确认 FAILURE:失败 FINISH:成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约授权一体化订单子任务单信息
        /// </summary>
        [XmlArray("task_infos")]
        [XmlArrayItem("sub_task_info")]
        public List<SubTaskInfo> TaskInfos { get; set; }
    }
}
