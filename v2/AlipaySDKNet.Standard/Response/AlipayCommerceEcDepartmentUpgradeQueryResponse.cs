using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentUpgradeQueryResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentUpgradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 待升级的部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 主企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 升级工单id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 子企业签约因公付链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 升级工单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子企业共同账户id
        /// </summary>
        [XmlElement("sub_account_id")]
        public string SubAccountId { get; set; }

        /// <summary>
        /// 子企业id
        /// </summary>
        [XmlElement("sub_enterprise_id")]
        public string SubEnterpriseId { get; set; }

        /// <summary>
        /// 子企业企业名称
        /// </summary>
        [XmlElement("sub_enterprise_name")]
        public string SubEnterpriseName { get; set; }
    }
}
