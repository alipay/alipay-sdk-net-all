using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDepartmentSublistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDepartmentSublistQueryModel : AopObject
    {
        /// <summary>
        /// 部门id，特殊值 -1 表示查询根部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
