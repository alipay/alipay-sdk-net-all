using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntsignDetailQueryResponse.
    /// </summary>
    public class AlipayBossProdAntsignDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 签署任务结果列表
        /// </summary>
        [XmlArray("ant_sign_task_result_list")]
        [XmlArrayItem("ant_sign_task_result")]
        public List<AntSignTaskResult> AntSignTaskResultList { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 签署流程ID
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }

        /// <summary>
        /// 签署流程状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// ANT_GROUP
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
