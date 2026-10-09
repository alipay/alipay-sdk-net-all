using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcSupplierHomepageurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcSupplierHomepageurlQueryModel : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 主企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控信息
        /// </summary>
        [XmlElement("expense_control_info")]
        public ExpenseControlInfo ExpenseControlInfo { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
