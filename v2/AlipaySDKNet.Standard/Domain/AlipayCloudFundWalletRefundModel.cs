using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletRefundModel : AopObject
    {
        /// <summary>
        /// 退款金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

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
        /// 待邀请的用户支付宝账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID 支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 钱包产品code一般为FUND_TRUSTSHIP
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
