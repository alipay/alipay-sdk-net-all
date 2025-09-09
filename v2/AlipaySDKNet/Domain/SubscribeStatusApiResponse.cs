using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscribeStatusApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeStatusApiResponse : AopObject
    {
        /// <summary>
        /// 订阅状态 会员版本在有效期内：VALID 会员版本已过期：INVALID
        /// </summary>
        [XmlElement("member_status")]
        public string MemberStatus { get; set; }

        /// <summary>
        /// 用来展示订阅信息
        /// </summary>
        [XmlElement("subscribe_member_info_d_t_o")]
        public SubscribeMemberInfoDTO SubscribeMemberInfoDTO { get; set; }
    }
}
