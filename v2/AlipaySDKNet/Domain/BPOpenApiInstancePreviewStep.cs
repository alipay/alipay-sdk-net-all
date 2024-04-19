using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPOpenApiInstancePreviewStep Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiInstancePreviewStep : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 错误信息. 如果该节点预演失败时，则将错误信息填入到该字段.
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("finish_date")]
        public string FinishDate { get; set; }

        /// <summary>
        /// next也是一个复杂对象BPOpenApiInstancePreviewStep，平台无法循环嵌套使用，故定义成String，使用方请自行解析
        /// </summary>
        [XmlElement("next")]
        public string Next { get; set; }

        /// <summary>
        /// 节点展示名称
        /// </summary>
        [XmlElement("node")]
        public string Node { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 源头活动id
        /// </summary>
        [XmlElement("source_act_id")]
        public long SourceActId { get; set; }

        /// <summary>
        /// sub_steps是一复杂对象列表：List<BPOpenApiInstancePreviewStep>, 由于平台不能循环嵌套使用，故定义成String，使用方自行解析
        /// </summary>
        [XmlElement("sub_steps")]
        public string SubSteps { get; set; }

        /// <summary>
        /// 该节点是否预演成功. 默认为true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 步骤单元集合
        /// </summary>
        [XmlArray("units")]
        [XmlArrayItem("step_unit")]
        public List<StepUnit> Units { get; set; }
    }
}
