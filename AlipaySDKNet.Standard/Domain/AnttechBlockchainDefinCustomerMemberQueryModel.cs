using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinCustomerMemberQueryModel : AopObject
    {
        /// <summary>
        /// 指定业务线
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// DID, IP_ID, IP_ROLE_ID
        /// </summary>
        [XmlElement("map_id_type")]
        public string MapIdType { get; set; }

        /// <summary>
        /// 映射id
        /// </summary>
        [XmlElement("map_id_value")]
        public string MapIdValue { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员角色
        /// </summary>
        [XmlElement("member_role_type")]
        public string MemberRoleType { get; set; }
    }
}
