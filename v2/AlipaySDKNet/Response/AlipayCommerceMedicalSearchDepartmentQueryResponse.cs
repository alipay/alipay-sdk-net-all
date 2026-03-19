using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSearchDepartmentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalSearchDepartmentQueryResponse : AopResponse
    {
        /// <summary>
        /// 科室列表
        /// </summary>
        [XmlElement("depart_list")]
        public DepartmentInfoVO DepartList { get; set; }
    }
}
