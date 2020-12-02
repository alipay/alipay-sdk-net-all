using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DefiCustUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DefiCustUserDTO : AopObject
    {
        /// <summary>
        /// 会员信息
        /// </summary>
        [XmlElement("member_info")]
        public DefiCustMemberDTO MemberInfo { get; set; }

        /// <summary>
        /// ACTIVE("ACTIVE", "激活状态"), FROZEN("FROZEN", "冻结状态"), DISABLED("DISABLED", "禁用状态"),;
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户手机
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
