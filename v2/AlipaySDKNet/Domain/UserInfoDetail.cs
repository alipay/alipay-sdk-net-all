using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoDetail : AopObject
    {
        /// <summary>
        /// 网商会员ID，可选
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商会员角色ID，可选
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 平台端会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 账户ID，根据类型而不同
        /// </summary>
        [XmlElement("user_info_id")]
        public string UserInfoId { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("user_info_type")]
        public string UserInfoType { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
