using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvLiteresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvLiteresultSyncModel : AopObject
    {
        /// <summary>
        /// 人工识别结果
        /// </summary>
        [XmlArray("contrast_result")]
        [XmlArrayItem("contrast_result")]
        public List<ContrastResult> ContrastResult { get; set; }

        /// <summary>
        /// 货柜交易号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
