using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendAccountDTO : AopObject
    {
        /// <summary>
        /// 推荐商家支付宝登录账号，邮箱或手机号码，脱敏处理
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 推荐商家支付宝账号名称，脱敏处理
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
