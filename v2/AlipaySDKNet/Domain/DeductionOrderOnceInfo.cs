using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionOrderOnceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionOrderOnceInfo : AopObject
    {
        /// <summary>
        /// 凭证序列号
        /// </summary>
        [XmlElement("certificate_serial")]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// 扣款金额，单位：分
        /// </summary>
        [XmlElement("deduction_amount")]
        public long DeductionAmount { get; set; }

        /// <summary>
        /// 核销现金价值，单位：分
        /// </summary>
        [XmlElement("deduction_cash")]
        public long DeductionCash { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }
    }
}
