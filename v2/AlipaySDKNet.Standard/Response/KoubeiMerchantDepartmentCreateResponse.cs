using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentCreateResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentCreateResponse : AopResponse
    {
        /// <summary>
        /// 员工管理场景商户创建部门成功时返回的部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }
    }
}
