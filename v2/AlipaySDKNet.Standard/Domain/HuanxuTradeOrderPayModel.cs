using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HuanxuTradeOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class HuanxuTradeOrderPayModel : AopObject
    {
        /// <summary>
        /// 聚合支付的支付渠道，焕旭分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 透传扩展信息
        /// </summary>
        [XmlElement("ext_params")]
        public FinExtParams ExtParams { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("goods_infos")]
        public GoodsDetailInfo GoodsInfos { get; set; }

        /// <summary>
        /// 是否异步支付，true/false，不传默认为false。
        /// </summary>
        [XmlElement("is_async_pay")]
        public string IsAsyncPay { get; set; }

        /// <summary>
        /// 商户订单号，merchant_order_no唯一对应业务上一笔订单，相同的订单需传入相同的merchant_order_no
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 支付金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// CASH现金模式（默认值，传入这个值，则表示仅仅支持银行卡现金）BILL票据模式（传入这个值，则表示仅仅支持银行票据）CASH_BILL现金/票据都支持模式
        /// </summary>
        [XmlElement("pay_entity_mode")]
        public string PayEntityMode { get; set; }

        /// <summary>
        /// 支付模式，焕旭分配，目前只支持GUARANTEE_PAY(担保支付模式)
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 支付请求号，对应一笔业务订单下的一次支付请求，不同支付请求需保证请求号唯一
        /// </summary>
        [XmlElement("pay_request_no")]
        public string PayRequestNo { get; set; }

        /// <summary>
        /// 支付终端，指支付来源的设备端，焕旭分配，目前支持PC/APP
        /// </summary>
        [XmlElement("pay_terminal")]
        public string PayTerminal { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee")]
        public UserIdentity Payee { get; set; }

        /// <summary>
        /// 收款方的额外信息，包含会员信息和支付机构账号信息
        /// </summary>
        [XmlElement("payee_ext")]
        public UserIdentityExt PayeeExt { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer")]
        public UserIdentity Payer { get; set; }

        /// <summary>
        /// 付款方的额外信息，包含会员信息和支付机构账号信息
        /// </summary>
        [XmlElement("payer_ext")]
        public UserIdentityExt PayerExt { get; set; }

        /// <summary>
        /// 支付说明
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
