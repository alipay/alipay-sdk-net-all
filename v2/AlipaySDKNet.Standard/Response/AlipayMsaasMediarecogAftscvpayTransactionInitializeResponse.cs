using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
