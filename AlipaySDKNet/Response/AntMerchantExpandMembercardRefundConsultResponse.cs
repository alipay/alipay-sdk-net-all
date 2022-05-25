using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardRefundConsultResponse.
    /// </summary>
    public class AntMerchantExpandMembercardRefundConsultResponse : AopResponse
    {
        /// <summary>
        /// 退卡明细
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("member_card_refund_detail")]
        public List<MemberCardRefundDetail> Details { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [XmlElement("refund_total_amount")]
        public string RefundTotalAmount { get; set; }

        /// <summary>
        /// 退权益金总金额
        /// </summary>
        [XmlElement("refund_total_benefit_amount")]
        public string RefundTotalBenefitAmount { get; set; }

        /// <summary>
        /// 退优惠总金额
        /// </summary>
        [XmlElement("refund_total_discount_amount")]
        public string RefundTotalDiscountAmount { get; set; }

        /// <summary>
        /// 退券总金额
        /// </summary>
        [XmlElement("refund_total_voucher_amount")]
        public string RefundTotalVoucherAmount { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("total_balance")]
        public string TotalBalance { get; set; }

        /// <summary>
        /// 本金余额
        /// </summary>
        [XmlElement("total_principal_balance")]
        public string TotalPrincipalBalance { get; set; }
    }
}
