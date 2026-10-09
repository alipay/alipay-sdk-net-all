using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedregisterDepartmentsQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedregisterDepartmentsQueryResponse : AopResponse
    {
        /// <summary>
        /// 该接口返回科室列表（非树）
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("department_v_o")]
        public List<DepartmentVO> Data { get; set; }
    }
}
