using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountMemberDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountMemberDTO : AopObject
    {
        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlElement("account_quota")]
        public JointAccountQuotaDTO AccountQuota { get; set; }

        /// <summary>
        /// 成员扩展信息
        /// </summary>
        [XmlElement("member_ext_info")]
        public MemberExtInfo MemberExtInfo { get; set; }

        /// <summary>
        /// 姓名，脱敏输出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 成员状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户会员号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
