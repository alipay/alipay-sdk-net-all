using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountMemberQuitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountMemberQuitModel : AopObject
    {
        /// <summary>
        /// 小荷包群id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 产品码下的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 被解绑用户唯一标识，即联通侧设备id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 被解绑用户唯一标识类型
        /// </summary>
        [XmlElement("member_type")]
        public string MemberType { get; set; }

        /// <summary>
        /// 业务场景标识JOINT_ACCOUNT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 绑定流程id
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("request_open_id")]
        public string RequestOpenId { get; set; }

        /// <summary>
        /// 操作人支付宝侧唯一标识
        /// </summary>
        [XmlElement("request_user_id")]
        public string RequestUserId { get; set; }

        /// <summary>
        /// 支付宝侧用户唯一标识类型
        /// </summary>
        [XmlElement("request_user_type")]
        public string RequestUserType { get; set; }
    }
}
