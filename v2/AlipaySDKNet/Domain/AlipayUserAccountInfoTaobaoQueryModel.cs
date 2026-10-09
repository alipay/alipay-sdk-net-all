using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountInfoTaobaoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountInfoTaobaoQueryModel : AopObject
    {
        /// <summary>
        /// target+否+手淘端内绑定支付宝账号+taobaoBindAlipay+固定值+仅支持手淘绑定支付宝链路使用
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// token+唯一+手淘端内绑定支付宝账号+无+手淘绑定支付宝链路登录支付宝成功下发+仅支持手淘绑定支付宝链路使用
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
