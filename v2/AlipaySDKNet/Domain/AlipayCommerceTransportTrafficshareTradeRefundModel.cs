using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTrafficshareTradeRefundModel : AopObject
    {
        /// <summary>
        /// 金额单位 
        /// </summary>
        [XmlElement("amount_unit")]
        public string AmountUnit { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 操作人工号或者姓名
        /// </summary>
        [XmlElement("op_name")]
        public string OpName { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号。支付宝交易号和商户订单号 out_biz_no 不能同时为空，两者同时存在时，优先取值trade_no
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款金额。需要退款的金额，该金额不能大于订单金额。币种：人民币 注：如果正向交易使用了营销，该退款金额包含营销金额，支付宝会按业务规则分配营销和买家自有资金分别退多少，默认优先退买家的自有资金。如交易总金额100元，用户支付时使用了80元自有资金和20元无资金流的营销券，商家实际收款80元。如果首次请求退款60元，则60元全部从商家收款资金扣除退回给用户自有资产；如果再请求退款40元，则从商家收款资金扣除20元退回用户资产以及把20元的营销券退回给用户（券是否可再使用取决于券的规则配置）。 单位：取自amount_unit ，元或者分
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一。注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。 
        /// </summary>
        [XmlElement("refund_batch_id")]
        public string RefundBatchId { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
