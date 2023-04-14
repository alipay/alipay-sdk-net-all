using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberStatusRespDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MemberStatusRespDTO : AopObject
    {
        /// <summary>
        /// 用户支付宝会员openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工当前状态： 邀请中（PROCESSING）、正常（NORMAL）、不在企业中（OUT）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝2088会员号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
