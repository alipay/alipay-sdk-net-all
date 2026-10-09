using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionOrderPageProcessorResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionOrderPageProcessorResponse : AopObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("deduction_order_date")]
        public string DeductionOrderDate { get; set; }

        /// <summary>
        /// 扣款单id
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("deduction_time")]
        public string DeductionTime { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
