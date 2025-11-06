using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorRecommendQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctorRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索推荐医生信息
        /// </summary>
        [XmlArray("hdf_doctor_list")]
        [XmlArrayItem("recommend_doctor_detail")]
        public List<RecommendDoctorDetail> HdfDoctorList { get; set; }
    }
}
