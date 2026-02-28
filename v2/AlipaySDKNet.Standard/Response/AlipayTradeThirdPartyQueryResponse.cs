using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeThirdPartyQueryResponse.
    /// </summary>
    public class AlipayTradeThirdPartyQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 助贷平台PID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 资方在助贷平台侧入驻的smid
        /// </summary>
        [XmlElement("secondary_merchant_no")]
        public string SecondaryMerchantNo { get; set; }

        /// <summary>
        /// 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 【注意事项】在未生成真实交易时，不返回，需要商户调用交易查询接口或接入支付通知，获取最终的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
