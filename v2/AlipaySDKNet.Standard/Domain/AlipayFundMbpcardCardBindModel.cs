using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardCardBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardCardBindModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_identity_id")]
        public string AlipayIdentityId { get; set; }

        /// <summary>
        /// 支付宝账号类型 ALIPAY_LOGON_ID：登录号 ALIPAY_USER_ID：会员号
        /// </summary>
        [XmlElement("alipay_identity_type")]
        public string AlipayIdentityType { get; set; }

        /// <summary>
        /// 绑卡用户名称
        /// </summary>
        [XmlElement("bind_user_name")]
        public string BindUserName { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// x6570cNf
        /// </summary>
        [XmlElement("card_password")]
        public string CardPassword { get; set; }

        /// <summary>
        /// 支付宝开放平台账号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
