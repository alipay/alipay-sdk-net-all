using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserQueryInfo : AopObject
    {
        /// <summary>
        /// 支付宝登录账户的手机号,非患者手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
