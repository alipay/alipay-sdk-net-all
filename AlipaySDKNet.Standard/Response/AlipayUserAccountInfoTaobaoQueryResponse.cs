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
        /// 脱敏支付宝外标+是+手淘端内绑定支付宝账号+无+token获取+无
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }
    }
}
