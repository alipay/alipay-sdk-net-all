using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneTaskflowBatchFinishModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extra_map")]
        public string ExtraMap { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 时效任务流水ID
        /// </summary>
        [XmlArray("task_flow_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskFlowIdList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
