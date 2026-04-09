using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherRefundDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherRefundDetailInfo : AopObject
    {
        /// <summary>
        /// 取消核销优惠金额, 单位:元
        /// </summary>
        [XmlElement("voucher_refund_amount")]
        public string VoucherRefundAmount { get; set; }

        /// <summary>
        /// 本次取消核销次数
        /// </summary>
        [XmlElement("voucher_refund_use_times")]
        public long VoucherRefundUseTimes { get; set; }
    }
}
