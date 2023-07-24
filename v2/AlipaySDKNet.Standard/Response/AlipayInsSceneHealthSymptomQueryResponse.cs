using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthSymptomQueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthSymptomQueryResponse : AopResponse
    {
        /// <summary>
        /// 症状列表
        /// </summary>
        [XmlArray("symptom_list")]
        [XmlArrayItem("health_symptom")]
        public List<HealthSymptom> SymptomList { get; set; }
    }
}
