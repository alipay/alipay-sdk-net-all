using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthorizeUniApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthorizeUniApplyModel : AopObject
    {
        /// <summary>
        /// 超时时间，过期跳转链接失效，格式为yyyy-MM-dd HH:mm。不传，有效期默认7天
        /// </summary>
        [XmlElement("apply_expire_time")]
        public string ApplyExpireTime { get; set; }

        /// <summary>
        /// 业务扩展数据
        /// </summary>
        [XmlElement("auth_biz_param")]
        public AuthBizParam AuthBizParam { get; set; }

        /// <summary>
        /// 授权失效时间，格式为yyyy-MM-dd HH:mm。 不传默认2115-01-01 00:00过期
        /// </summary>
        [XmlElement("auth_expire_time")]
        public string AuthExpireTime { get; set; }

        /// <summary>
        /// 授权跳转类型，有限枚举：SHORT_URL
        /// </summary>
        [XmlElement("authorize_link_type")]
        public string AuthorizeLinkType { get; set; }

        /// <summary>
        /// 业务场景码，固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转渠道，优先枚举值: pc, h5, tinyapp
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 授权申请外部业务号，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("partner_info")]
        public AuthParticipantInfo PartnerInfo { get; set; }

        /// <summary>
        /// 授权主体
        /// </summary>
        [XmlElement("principal_info")]
        public AuthParticipantInfo PrincipalInfo { get; set; }

        /// <summary>
        /// 业务产品码，固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 第三方数据信息
        /// </summary>
        [XmlElement("third_party_info")]
        public AuthParticipantInfo ThirdPartyInfo { get; set; }
    }
}
