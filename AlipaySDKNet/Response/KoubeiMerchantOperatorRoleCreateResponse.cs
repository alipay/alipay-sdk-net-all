using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增返回角色roleId,修改则返回修改的roleId.
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }
    }
}
