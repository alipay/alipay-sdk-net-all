using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvInnermanualinfoNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvInnermanualinfoNotifyModel : AopObject
    {
        /// <summary>
        /// 外部原因
        /// </summary>
        [XmlElement("external_reason")]
        public string ExternalReason { get; set; }

        /// <summary>
        /// 人工类型
        /// </summary>
        [XmlElement("manual_type")]
        public string ManualType { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
