using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundConfirmCommitResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundConfirmCommitResult : AopObject
    {
        /// <summary>
        /// 退款前向商户确认退款为拒绝退款后备注的退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 确认退款结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 券码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
