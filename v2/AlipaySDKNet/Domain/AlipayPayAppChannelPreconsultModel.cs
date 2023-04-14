using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppChannelPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppChannelPreconsultModel : AopObject
    {
        /// <summary>
        /// 对一笔交易的具体描述信息。如果是多种商品，请将商品描述字符串累加传给body。
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 买家的支付宝唯一用户号（2088开头的16位纯数字）。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明。  详情参见： alipay.trade.app.pay。
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商品主类型。0—虚拟类商品；1—实物类商品。 说明：虚拟类商品不支持使用花呗渠道。
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，需保证商家系统中唯一。仅支持数字、字母、下划线。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，默认为 QUICK_MSECURITY_PAY（App支付）。枚举支持： QUICK_MSECURITY_PAY：App支付； CYCLE_PAY_AUTH：周期扣款。 周期扣款产品场景必填。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商品标题/交易标题/订单标题/订单关键字等。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位为人民币（元），取值范围为 0.01~100000000.00，精确到小数点后两位。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
