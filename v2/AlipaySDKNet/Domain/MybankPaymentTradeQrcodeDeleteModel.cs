using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeQrcodeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeQrcodeDeleteModel : AopObject
    {
        /// <summary>
        /// 加密token
        /// </summary>
        [XmlElement("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
