using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdatedAuthenticationDetails Data Structure.
    /// </summary>
    [Serializable]
    public class UpdatedAuthenticationDetails : AopObject
    {
        /// <summary>
        /// 鉴权机制
        /// </summary>
        [XmlArray("authentication_mechanisms")]
        [XmlArrayItem("string")]
        public List<string> AuthenticationMechanisms { get; set; }

        /// <summary>
        /// 随机数
        /// </summary>
        [XmlElement("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// 交易签名信息
        /// </summary>
        [XmlElement("partial_transaction_details_signature")]
        public string PartialTransactionDetailsSignature { get; set; }

        /// <summary>
        /// 6位密码或者长密码
        /// </summary>
        [XmlElement("pin_format")]
        public string PinFormat { get; set; }

        /// <summary>
        /// 签名秘钥
        /// </summary>
        [XmlElement("signing_key_material")]
        public string SigningKeyMaterial { get; set; }
    }
}
