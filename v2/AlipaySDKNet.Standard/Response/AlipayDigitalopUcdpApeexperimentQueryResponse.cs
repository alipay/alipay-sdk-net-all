using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeexperimentQueryResponse : AopResponse
    {
        /// <summary>
        /// 实验信息，包含对照组和算法组的数据
        /// </summary>
        [XmlArray("experiment_info_list")]
        [XmlArrayItem("experiment_info")]
        public List<ExperimentInfo> ExperimentInfoList { get; set; }

        /// <summary>
        /// 当前正在运行的实验id，为空说明没有实验正在运行
        /// </summary>
        [XmlElement("running_experiment_id")]
        public string RunningExperimentId { get; set; }
    }
}
