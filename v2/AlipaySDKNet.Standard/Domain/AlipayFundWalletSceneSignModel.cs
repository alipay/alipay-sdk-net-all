using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletSceneSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletSceneSignModel : AopObject
    {
        /// <summary>
        /// 钱包业务的场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否校验主体身份信息  传入：true/false
        /// </summary>
        [XmlElement("need_check_identity")]
        public bool NeedCheckIdentity { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 钱包营销规则
        /// </summary>
        [XmlElement("wallet_marketing_rule")]
        public WalletMarketingRule WalletMarketingRule { get; set; }

        /// <summary>
        /// 钱包模版id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }

        /// <summary>
        /// 用户主体身份信息
        /// </summary>
        [XmlElement("wallet_user_identity_info")]
        public WalletUserIdentityInfo WalletUserIdentityInfo { get; set; }
    }
}
