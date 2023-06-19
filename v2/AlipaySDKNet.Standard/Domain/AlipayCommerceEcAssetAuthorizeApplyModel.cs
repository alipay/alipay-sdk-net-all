using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAssetAuthorizeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAssetAuthorizeApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 法人支付宝登录账号
        /// </summary>
        [XmlElement("ebe_alipay_logon_id")]
        public string EbeAlipayLogonId { get; set; }

        /// <summary>
        /// 企业支付宝登录账号
        /// </summary>
        [XmlElement("ent_alipay_logon_id")]
        public string EntAlipayLogonId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约终端类型，默认MOBILE
        /// </summary>
        [XmlElement("sign_terminal")]
        public string SignTerminal { get; set; }
    }
}
