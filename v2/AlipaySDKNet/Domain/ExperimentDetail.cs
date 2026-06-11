using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExperimentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ExperimentDetail : AopObject
    {
        /// <summary>
        /// 实验组名称，根据用户id分流结果获取达尔文平台上对应的实验组名称
        /// </summary>
        [XmlElement("experiment_name")]
        public string ExperimentName { get; set; }

        /// <summary>
        /// 实验参数
        /// </summary>
        [XmlElement("experiment_parameters")]
        public string ExperimentParameters { get; set; }
    }
}
