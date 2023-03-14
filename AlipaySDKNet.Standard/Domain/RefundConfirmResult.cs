using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundConfirmResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundConfirmResult : AopObject
    {
        /// <summary>
        /// 退款备注的原因
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
