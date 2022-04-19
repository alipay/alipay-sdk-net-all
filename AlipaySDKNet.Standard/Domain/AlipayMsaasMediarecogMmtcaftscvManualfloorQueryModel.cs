using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvManualfloorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvManualfloorQueryModel : AopObject
    {
        /// <summary>
        /// 视觉交易号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
