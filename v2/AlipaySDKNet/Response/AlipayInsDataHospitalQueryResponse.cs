using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataHospitalQueryResponse.
    /// </summary>
    public class AlipayInsDataHospitalQueryResponse : AopResponse
    {
        /// <summary>
        /// 名称相似度Top10的医院
        /// </summary>
        [XmlArray("hospitals")]
        [XmlArrayItem("hospital_d_t_o")]
        public List<HospitalDTO> Hospitals { get; set; }
    }
}
