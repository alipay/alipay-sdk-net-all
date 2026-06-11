using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletOrderQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠前金额(分)
        /// </summary>
        [XmlElement("before_discount_money")]
        public string BeforeDiscountMoney { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付金额(分)
        /// </summary>
        [XmlElement("money")]
        public string Money { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态/支付状态  - INIT(待支付)  - PAY_SUCCESS(支付成功)  - WAIT_REFUND(待退款)  - REFUND_SUCCESS(退款成功)  - CLOSED(已关闭)
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型（新购、续费、变配等）  - NEW(新签)  - RENEW(续费)  - MODIFY(变配)  - REFUND(退款)
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 产品code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
