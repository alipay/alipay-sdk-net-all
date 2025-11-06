using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryDetailPositionPipelineConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryDetailPositionPipelineConfigVO : AopObject
    {
        /// <summary>
        /// 展位投放pipeline节点配置
        /// </summary>
        [XmlElement("pipeline_node_config")]
        public string PipelineNodeConfig { get; set; }

        /// <summary>
        /// pipeline节点表达式，stockpromotion使用节点表达式进行pipeline计算
        /// </summary>
        [XmlElement("pipeline_node_expressions")]
        public string PipelineNodeExpressions { get; set; }

        /// <summary>
        /// 展位码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }
    }
}
