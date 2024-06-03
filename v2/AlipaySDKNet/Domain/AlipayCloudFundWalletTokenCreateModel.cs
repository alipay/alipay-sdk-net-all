using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletTokenCreateModel : AopObject
    {
        /// <summary>
        /// 格式必须为： https://开头域名链接地址 或者 alipays://开头的支付宝小程序链接。 2. 需要保证传入的 returnUrl 链接能够有效访问
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 钱包场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 待邀请用户的支付宝账号： identity_type是ALIPAY_USER_ID填支付宝会员账号； 是ALIPAY_LOGON_ID 填支付宝登录号（支持邮箱和手机号格式）
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 待邀请用户的支付宝账号： identity_type是ALIPAY_USER_ID填支付宝会员账号； 是ALIPAY_LOGON_ID 填支付宝登录号（支持邮箱和手机号格式）
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 待邀请的用户支付宝账号类型，目前支持如下类型：  1、ALIPAY_USER_ID  支付宝的会员ID  2、ALIPAY_LOGON_ID 支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 钱包产品code一般为FUND_TRUSTSHIP
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 如果账号类型是ALIPAY_LOGIN_ID，则必传用户真实姓名，进行信息校验
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 是否跳过结果页,true为跳过，false为不跳过。默认不跳过
        /// </summary>
        [XmlElement("skip_result")]
        public bool SkipResult { get; set; }

        /// <summary>
        /// 钱包模板id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
