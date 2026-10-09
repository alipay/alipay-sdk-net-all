using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountMemberAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountMemberAddModel : AopObject
    {
        /// <summary>
        /// 产品码下的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 关系绑定操作超时时间，单位s
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 被邀请账号唯一标识，商户侧背绑定账号id
        /// </summary>
        [XmlElement("invitee_id")]
        public string InviteeId { get; set; }

        /// <summary>
        /// 被邀请账号类型
        /// </summary>
        [XmlElement("invitee_type")]
        public string InviteeType { get; set; }

        /// <summary>
        /// 邀请账号唯一标识，商户侧发起绑定账号id，代表商户侧该用户唯一标识
        /// </summary>
        [XmlElement("inviter_id")]
        public string InviterId { get; set; }

        /// <summary>
        /// 邀请账号类型
        /// </summary>
        [XmlElement("inviter_type")]
        public string InviterType { get; set; }

        /// <summary>
        /// 关系绑定唯一单号，需要保证唯一，不同用户绑定不会出现相同单号，同用户多次绑定不会出现相同单号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务场景标识JOINT_ACCOUNT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
