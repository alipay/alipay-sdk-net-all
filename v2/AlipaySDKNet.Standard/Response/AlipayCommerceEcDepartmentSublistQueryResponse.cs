using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentSublistQueryResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentSublistQueryResponse : AopResponse
    {
        /// <summary>
        /// 部门id列表
        /// </summary>
        [XmlArray("department_id_list")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIdList { get; set; }
    }
}
