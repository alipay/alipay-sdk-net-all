using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeQrcodePayresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeQrcodePayresultQueryModel : AopObject
    {
        /// <summary>
        /// 加密token
        /// </summary>
        [XmlElement("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
