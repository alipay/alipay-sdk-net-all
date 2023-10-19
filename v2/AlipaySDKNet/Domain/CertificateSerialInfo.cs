using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateSerialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateSerialInfo : AopObject
    {
        /// <summary>
        /// 次序号的金额信息
        /// </summary>
        [XmlElement("amount_info")]
        public CertificateInstanceAmountInfo AmountInfo { get; set; }

        /// <summary>
        /// 次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 次序号状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
