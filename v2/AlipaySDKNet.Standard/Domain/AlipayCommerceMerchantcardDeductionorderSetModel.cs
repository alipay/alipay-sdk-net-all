using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardDeductionorderSetModel : AopObject
    {
        /// <summary>
        /// 售卖订单id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 核销订单id
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// （1）退款时：当funding_model=PREPAID，会退次数； 当funding_model=PAY_AFTER_CONSUMPTION_MODE，不会退次数；
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// (1) 当 card_type=AXF_MONEY_TIME_CARD && operation_type=REFUND 时，该字段代表退款次数，会逆向按顺序依次退款
        /// </summary>
        [XmlElement("operation_value")]
        public long OperationValue { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
