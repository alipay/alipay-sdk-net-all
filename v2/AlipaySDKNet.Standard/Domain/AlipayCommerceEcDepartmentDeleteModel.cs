using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDepartmentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDepartmentDeleteModel : AopObject
    {
        /// <summary>
        /// 部门id
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
