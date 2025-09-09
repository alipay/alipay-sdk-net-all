using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcSupplierUrlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcSupplierUrlQueryModel : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控规则id
        /// </summary>
        [XmlElement("expense_rule_id")]
        public string ExpenseRuleId { get; set; }

        /// <summary>
        /// 如果传false（默认值），如果员工未签约因公付，接口会抛异常；  如果传true，如果员工未签约因公付，则返回签约链接（员工签约成功后会跳转供给链接）
        /// </summary>
        [XmlElement("need_sign_url")]
        public bool NeedSignUrl { get; set; }

        /// <summary>
        /// 供给id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
