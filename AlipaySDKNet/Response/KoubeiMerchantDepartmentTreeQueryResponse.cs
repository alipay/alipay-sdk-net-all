using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentTreeQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentTreeQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户部门组织模型集合，根据返回的结果构造出商户的部门树
        /// </summary>
        [XmlArray("department_dtos")]
        [XmlArrayItem("department_d_t_o")]
        public List<DepartmentDTO> DepartmentDtos { get; set; }
    }
}
