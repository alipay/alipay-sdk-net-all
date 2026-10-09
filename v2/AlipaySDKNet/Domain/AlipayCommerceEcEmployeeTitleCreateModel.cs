using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeTitleCreateModel : AopObject
    {
        /// <summary>
        /// 员工与抬头关系列表
        /// </summary>
        [XmlArray("employee_title_list")]
        [XmlArrayItem("employee_title_d_t_o")]
        public List<EmployeeTitleDTO> EmployeeTitleList { get; set; }
    }
}
