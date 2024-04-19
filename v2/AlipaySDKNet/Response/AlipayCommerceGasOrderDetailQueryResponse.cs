using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasOrderDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceGasOrderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单使用的支付宝券信息
        /// </summary>
        [XmlElement("alipay_voucher")]
        public FuelVoucherInfo AlipayVoucher { get; set; }

        /// <summary>
        /// 订单的直降金额 单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单选择的油品类型
        /// </summary>
        [XmlElement("gas_type")]
        public string GasType { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 订单选择的油枪
        /// </summary>
        [XmlElement("nozzle_number")]
        public string NozzleNumber { get; set; }

        /// <summary>
        /// 订单的总金额 单位分
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单需要支付的金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单的服务费
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 油站的唯一编号
        /// </summary>
        [XmlElement("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 订单各种状态 WAIT_PAY 待支付 CLOSE 关闭 PAY 支付完成 FINISH 加油完成 REFUNDING 退款中 REFUND 已退款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户唯一id
        /// </summary>
        [XmlElement("user_unique_id")]
        public string UserUniqueId { get; set; }
    }
}
