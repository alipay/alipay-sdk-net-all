using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelLockerUserinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelLockerUserinfoSyncModel : AopObject
    {
        /// <summary>
        /// 用户支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// MEMBER_ID时必传
        /// </summary>
        [XmlElement("org_group_code")]
        public string OrgGroupCode { get; set; }

        /// <summary>
        /// 用户支付宝user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 关联用户ID
        /// </summary>
        [XmlElement("user_relate_id")]
        public string UserRelateId { get; set; }

        /// <summary>
        /// 关联用户ID类型
        /// </summary>
        [XmlElement("user_relate_type")]
        public string UserRelateType { get; set; }
    }
}
