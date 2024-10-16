using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardDeductionorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 售卖订单id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 默认的订单类型范围：TIMES_CARD、PERIOD_PAY、AXF_MERCHANT_PERIOD_PAY、AXF_PERIOD_PAY_INDIRECT
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 核销订单结束时间
        /// </summary>
        [XmlElement("deduction_end_date")]
        public string DeductionEndDate { get; set; }

        /// <summary>
        /// 核销订单开始时间
        /// </summary>
        [XmlElement("deduction_start_date")]
        public string DeductionStartDate { get; set; }

        /// <summary>
        /// （1）TIMES_CARD / PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY / AXF_MERCHANT_PERIOD_PAY_INDIRECT：UNPAID、PAYMENT_SUCCESS、PAYMENT_FAILED、REFUND （2）AXF_MONEY_TIME_CARD：INIT、FROZEN、CANCELLED、REDEEMING、PAYMENT_FAILED、PAYMENT_SUCCESS、REFUND、PART_REFUND
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 售卖订单结束时间
        /// </summary>
        [XmlElement("order_end_date")]
        public string OrderEndDate { get; set; }

        /// <summary>
        /// 售卖订单开始时间
        /// </summary>
        [XmlElement("order_start_date")]
        public string OrderStartDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
