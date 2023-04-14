using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentModifyResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改商户部门成功时返回的部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }
    }
}
