using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeWapPayResponse.
    /// </summary>
    public class AlipayTradeWapPayResponse : AopResponse
    {
        /// <summary>
        /// 商户原始订单号，最大长度限制32位
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户网站订单号，由商家自定义。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 用于跳转支付宝页面的信息，POST和GET方法生成内容不同：使用POST方法执行，结果为html form表单，在浏览器渲染即可；使用GET方法会得到支付宝URL，需要打开或重定向到该URL。建议使用POST方式。
        /// </summary>
        [XmlElement("pageRedirectionData")]
        public string PageRedirectionData { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 该笔订单的资金总额，单位为人民币（元），取值范围为 0.01~100000000.00，精确到小数点后两位。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。最长64位。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
