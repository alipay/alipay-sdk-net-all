using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleExternalAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleExternalAuthModel : AopObject
    {
        /// <summary>
        /// 用户的支付宝登陆号，可以是手机或邮箱
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }
    }
}
