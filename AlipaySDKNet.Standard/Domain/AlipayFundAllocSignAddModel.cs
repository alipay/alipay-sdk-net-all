using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAllocSignAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAllocSignAddModel : AopObject
    {
        /// <summary>
        /// 产品码由支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 1、identity_type为ALIPAY_USER_ID时，该字段需填写开户企业的支付宝会员ID（2088开头的16位数字字符串）； 2、identity_type是ALIPAY_LOGON_ID该字段需填写开户企业的的支付宝登录号。 3、identity_type是ALIPAY_OPEN_ID该字段需填写支付宝的opneId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// identity_type为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 1、ALIPAY_USER_ID： 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openId
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 平台唯一，幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转帐分佣产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
