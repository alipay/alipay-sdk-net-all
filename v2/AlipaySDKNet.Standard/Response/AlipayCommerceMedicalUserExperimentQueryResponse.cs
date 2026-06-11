using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalUserExperimentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalUserExperimentQueryResponse : AopResponse
    {
        /// <summary>
        /// 实验信息
        /// </summary>
        [XmlElement("experiment_detail")]
        public ExperimentDetail ExperimentDetail { get; set; }
    }
}
