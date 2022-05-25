using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountInfoTaobaoQueryResponse.
    /// </summary>
    public class AlipayUserAccountInfoTaobaoQueryResponse : AopResponse
    {
        /// <summary>
        /// alipay_user_id+是+手淘端内绑定支付宝账号+无+token获取+无
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户是否完成认证
        /// </summary>
        [XmlElement("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 脱敏支付宝外标+是+手淘端内绑定支付宝账号+无+token获取+无
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
