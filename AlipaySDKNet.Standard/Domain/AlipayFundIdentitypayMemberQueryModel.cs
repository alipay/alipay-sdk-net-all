using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIdentitypayMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIdentitypayMemberQueryModel : AopObject
    {
        /// <summary>
        /// 查询签约信息场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约方账号,当identity_type为ALIPAY_USER_ID时，是2088xx，当identity_type为ALIPAY_LOGON_ID时，是支付宝登录号，当identity_type为ALIPAY_OPEN_ID时，是支付宝openId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 签约方类型(ALIPAY_USER_ID或ALIPAY_LOGON_ID或ALIPAY_OPEN_ID)
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 支付宝openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部成员Id（全局唯一）
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 外部组织Id（全局唯一）
        /// </summary>
        [XmlElement("out_org_id")]
        public string OutOrgId { get; set; }

        /// <summary>
        /// 查询签约信息产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
