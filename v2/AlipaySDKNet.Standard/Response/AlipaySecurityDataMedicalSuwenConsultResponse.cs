using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataMedicalSuwenConsultResponse.
    /// </summary>
    public class AlipaySecurityDataMedicalSuwenConsultResponse : AopResponse
    {
        /// <summary>
        /// 素问医疗信息咨询结果列表
        /// </summary>
        [XmlArray("consult_result_list")]
        [XmlArrayItem("rc_med_consult_result")]
        public List<RcMedConsultResult> ConsultResultList { get; set; }
    }
}
