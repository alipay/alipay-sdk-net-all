using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceExtOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceExtOrderSyncModel : AopObject
    {
        /// <summary>
        /// 当回流的订单需要根据在光华平台录入的服务相关信息进行分佣的时候，需要传入在光华平台录入的服务的appCode 字段
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// appid，订单归属的小程序id，当order_type=1时 必填
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// body，商户关于该订单的描述性信息，非必填
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// buyer_id，服务用户的uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// category_code，商户通过aboss签约的产品的类目编码，当order_type=1，且签约时有类目编码，则必填。
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// json格式的额外参数配置，扩展需要。未做特殊说明不传
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// gmt_service, 订单发生时间，格式为 yyyy-MM-dd HH:mm:ss, 当order_type=1时填写订单交易时间；当order_type=2时填写订单退单时间。
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// open_id，订单买家的支付宝open_id，当order_type=1时 必填。open_id映射到的uid不可以和商户pid一样。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// order_type，必填字段，枚举可数。枚举值 '1' 代表正向收费订单，'2' 代表逆向退费订单，由调用方根据业务数据填写。
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 退款请求号，当order_type=2时必传。 标识一次退款请求，需要保证在外部交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号，最大长度64字符，需保证商户侧不重复。注意：退费时该参数需要和收费时保持一致，否则无法退费
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// product_code，商户通过aboss和支付宝签约的产品码，当order_type=1时 必填
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// refund_amount，当order_type=2时必填，退费金额。单位为元，不能大于订单总金额，支持两位小数
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// refund_reason，退款原因说明，商户自定义，非必填
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// subject，订单标题，非必填
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// total_amount，订单金额，当order_type为1时此参数必填。精确到小数点后2位，单位 元，最大值99999999.99元，最小值为0.01元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// trade_no，支付宝收单系统生成的订单号，非必填。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
