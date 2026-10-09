using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalTransvideoinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalTransvideoinfoQueryModel : AopObject
    {
        /// <summary>
        /// 交易id
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
