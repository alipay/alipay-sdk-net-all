using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeshopidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeshopidQueryModel : AopObject
    {
        /// <summary>
        /// 商户角色id，同步蚂蚁门店时的pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// ape维度的租户ID
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 商家侧门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
