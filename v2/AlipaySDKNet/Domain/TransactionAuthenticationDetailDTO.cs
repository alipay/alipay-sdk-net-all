using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransactionAuthenticationDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TransactionAuthenticationDetailDTO : AopObject
    {
        /// <summary>
        /// 支付打断推进方式
        /// </summary>
        [XmlArray("authentication_mechanisms")]
        [XmlArrayItem("string")]
        public List<string> AuthenticationMechanisms { get; set; }

        /// <summary>
        /// 密码校验方式
        /// </summary>
        [XmlElement("pin_format")]
        public string PinFormat { get; set; }
    }
}
