using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeBatchcreateModel : AopObject
    {
        /// <summary>
        /// 批量添加的员工信息列表
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("employee_batch_add_d_t_o")]
        public List<EmployeeBatchAddDTO> EmployeeList { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
