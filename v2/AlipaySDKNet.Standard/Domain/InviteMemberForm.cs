using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InviteMemberForm Data Structure.
    /// </summary>
    [Serializable]
    public class InviteMemberForm : AopObject
    {
        /// <summary>
        /// 开户账号：<br> -当identity_type是ALIPAY_USER_ID时填支付宝会员ID（2088开头）<br> -当identity_type是ALIPAY_LOGON_ID 时填支付宝登录号<br> -当identity_type是OUT_USER_ID时填外部平台的用户uid<br>
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： <br> -ALIPAY_USER_ID 支付宝的会员ID<br> -ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式<br> -OUT_USER_ID：外部用户uid，如钉钉侧的钉钉会员uid
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
