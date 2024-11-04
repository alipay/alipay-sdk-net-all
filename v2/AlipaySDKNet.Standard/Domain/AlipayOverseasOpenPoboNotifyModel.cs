using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPoboNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenPoboNotifyModel : AopObject
    {
        /// <summary>
        /// 留学VCC代付单收款方信息
        /// </summary>
        [XmlElement("beneficiary_info")]
        public TuitionISVPoboBeneficiaryInfo BeneficiaryInfo { get; set; }

        /// <summary>
        /// 留学vcc代付单买家信息
        /// </summary>
        [XmlElement("buyer_info")]
        public TuitionISVPoboBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 售后操作申请
        /// </summary>
        [XmlElement("manual_operation_apply")]
        public IndrPoboManualOperationApplyRequestDTO ManualOperationApply { get; set; }

        /// <summary>
        /// 留学vcc，代付订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 留学vcc代付单交易信息
        /// </summary>
        [XmlElement("payment_info")]
        public TuitionISVPoboPaymentInfo PaymentInfo { get; set; }

        /// <summary>
        /// 留学vcc代付结果
        /// </summary>
        [XmlElement("payment_result")]
        public TuitionISVPoboPaymentResult PaymentResult { get; set; }
    }
}
