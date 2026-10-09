using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FundExtInfo : AopObject
    {
        /// <summary>
        /// 出资主体账号，fund_identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）； 是ALIPAY_LOGON_ID 填支付宝登录号
        /// </summary>
        [XmlElement("fund_identity")]
        public string FundIdentity { get; set; }

        /// <summary>
        /// 出资主体账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("fund_identity_type")]
        public string FundIdentityType { get; set; }
    }
}
