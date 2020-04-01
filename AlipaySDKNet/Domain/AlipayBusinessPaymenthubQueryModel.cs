using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessPaymenthubQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessPaymenthubQueryModel : AopObject
    {
        /// <summary>
        /// 支付、打款、退款时候支付宝返回的唯一凭证id，调用方查询时候建议优先传入该值，内部处理时优先以该值为准。instruction_id和out_request_no不能同时为空。
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 指令类型，表明该笔查询是支付，打款还是退款，跟out_request_no一起使用。 支付：PAY 打款：DISBURSE 退款：REFUND
        /// </summary>
        [XmlElement("instruction_type")]
        public string InstructionType { get; set; }

        /// <summary>
        /// 商户订单号，merchant_order_no和out_request_no是一起使用。
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付、打款或退款请求号，out_request_no和instruction_id不能同时为空。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付请求号，out_request_no是一起使用。
        /// </summary>
        [XmlElement("pay_request_no")]
        public string PayRequestNo { get; set; }

        /// <summary>
        /// 付款方信息，跟out_request_no一起使用。
        /// </summary>
        [XmlElement("payer")]
        public UserIdentity Payer { get; set; }
    }
}
