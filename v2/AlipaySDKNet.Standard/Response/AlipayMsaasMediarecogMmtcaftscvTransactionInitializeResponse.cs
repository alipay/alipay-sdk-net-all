using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTransactionInitializeResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTransactionInitializeResponse : AopResponse
    {
        /// <summary>
        /// 下发给设备的视觉算法config
        /// </summary>
        [XmlElement("algorithm_config")]
        public string AlgorithmConfig { get; set; }

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
