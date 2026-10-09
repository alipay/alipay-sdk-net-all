using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeexperimentModifyModel : AopObject
    {
        /// <summary>
        /// 主要有四种操作类型createExperiment（创建新实验），adjustFlow(调整流量），offlineExperiment（下线当前实验），launchExperiment(推全算法版本),closeExperiment(关闭推荐)
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 调整的实验流量
        /// </summary>
        [XmlElement("flow_rate")]
        public long FlowRate { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
