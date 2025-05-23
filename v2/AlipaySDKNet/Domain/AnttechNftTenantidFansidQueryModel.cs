using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftTenantidFansidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftTenantidFansidQueryModel : AopObject
    {
        /// <summary>
        /// 租户用户账号
        /// </summary>
        [XmlElement("tenant_user_account")]
        public string TenantUserAccount { get; set; }
    }
}
