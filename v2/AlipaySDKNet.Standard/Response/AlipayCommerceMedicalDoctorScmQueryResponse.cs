using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorScmQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctorScmQueryResponse : AopResponse
    {
        /// <summary>
        /// 医生埋点信息列表
        /// </summary>
        [XmlArray("doctor_scm_list")]
        [XmlArrayItem("recommend_doctor_scm_detail")]
        public List<RecommendDoctorScmDetail> DoctorScmList { get; set; }
    }
}
