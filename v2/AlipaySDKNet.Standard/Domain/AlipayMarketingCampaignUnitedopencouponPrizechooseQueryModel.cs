using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnitedopencouponPrizechooseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnitedopencouponPrizechooseQueryModel : AopObject
    {
        /// <summary>
        /// 用户支付宝绑定手机号。user_id、login_id、bind_mobile三个参数至少有一个非空。
        /// </summary>
        [XmlElement("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// 活动id（对应活动详情页面的活动编号）
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 渠道来源参数
        /// </summary>
        [XmlElement("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 用户登录账号名：邮箱或手机号。该参数用于已知支付宝账号的活动查询与触发。user_id、login_id、bind_mobile三个参数至少有一个非空。
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 终端id
        /// </summary>
        [XmlElement("term_id")]
        public string TermId { get; set; }

        /// <summary>
        /// 支付宝用户uid：支付宝用户唯一标识。该参数用于已知支付宝账号的活动查询与触发。user_id、login_id、bind_mobile三个参数至少有一个非空。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
