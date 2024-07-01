using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundsTransferResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionFundsTransferResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部受理本次资金划拨请求时生成的流水单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 对应当前请求参数的「外部请求流水号 out_trade_no 」
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
