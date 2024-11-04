using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderExtInfoDTO : AopObject
    {
        /// <summary>
        /// 二方接入交易组件用于返佣计算的特殊参数，单位为元
        /// </summary>
        [XmlElement("addition_rebate_base_price")]
        public string AdditionRebateBasePrice { get; set; }

        /// <summary>
        /// 商家登录支付宝的邮箱账号或手机号，企业租赁业务传递该参数。
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 企业的统一社会信用代码，营业执照上有该信息，企业租赁业务需要传递该参数。
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 代扣协议签约场景值，商户可根据代扣产品常见场景值选择符合自身的行业场景，必须和合约中配置的一致。
        /// </summary>
        [XmlElement("deduct_sign_scene")]
        public string DeductSignScene { get; set; }

        /// <summary>
        /// 预约上门取件的时间,格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("door_time")]
        public string DoorTime { get; set; }

        /// <summary>
        /// 芝麻免押冻结资金签名串，调用 <a href="https://opendocs.alipay.com/open/e2e70da4_alipay.fund.auth.order.app.freeze?pathHash=1002681c&ref=api">alipay.fund.auth.order.app.freeze</a>生成，用于租赁场景冻结授权资金
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 订单的交易类型用于区分担保交易或者普通JSAPI支付，创支付单会对该类型进行校验，如果参入错误，创支付单会失败
        /// </summary>
        [XmlElement("order_trade_type")]
        public string OrderTradeType { get; set; }

        /// <summary>
        /// 外部风控参数信息
        /// </summary>
        [XmlElement("out_order_risk_info")]
        public string OutOrderRiskInfo { get; set; }

        /// <summary>
        /// 官方插件下单回调透传拓展参数
        /// </summary>
        [XmlElement("submit_order_callback_ext_str")]
        public string SubmitOrderCallbackExtStr { get; set; }

        /// <summary>
        /// 支付单交易号，用于信用下单不成功转普通支付。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
