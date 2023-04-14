using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceExtOrdercompleteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceExtOrdercompleteQueryModel : AopObject
    {
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
        /// sync_app_id，调用alipay.eco.cityservice.ext.order.sync回流接口传入的那个appid， 必填
        /// </summary>
        [XmlElement("sync_app_id")]
        public string SyncAppId { get; set; }
    }
}
