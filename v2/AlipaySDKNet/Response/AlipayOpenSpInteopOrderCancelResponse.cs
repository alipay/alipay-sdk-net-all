using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopOrderCancelResponse.
    /// </summary>
    public class AlipayOpenSpInteopOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 一体化作业主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 一体化作业任务操作信息
        /// </summary>
        [XmlArray("sub_task_op_infos")]
        [XmlArrayItem("inteop_sub_task_op_info_v_o")]
        public List<InteopSubTaskOpInfoVO> SubTaskOpInfos { get; set; }
    }
}
