using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaDigitalpayofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaDigitalpayofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 跨境数字支付用户数TOP5
        /// </summary>
        [XmlElement("cb_top_5_uv")]
        public string CbTop5Uv { get; set; }

        /// <summary>
        /// 跨境数字支付用户数
        /// </summary>
        [XmlElement("cb_total_uv")]
        public long CbTotalUv { get; set; }

        /// <summary>
        /// 打通国外钱包数
        /// </summary>
        [XmlElement("cb_wallet_cnt")]
        public long CbWalletCnt { get; set; }

        /// <summary>
        /// 数字支付商户TOP5
        /// </summary>
        [XmlElement("top_5_merchant")]
        public string Top5Merchant { get; set; }

        /// <summary>
        /// 数字支付累计金额(元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 数字支付商户覆盖数
        /// </summary>
        [XmlElement("total_merchants")]
        public long TotalMerchants { get; set; }

        /// <summary>
        /// 数字支付累计金额趋势
        /// </summary>
        [XmlElement("total_trend")]
        public string TotalTrend { get; set; }
    }
}
