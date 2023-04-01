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
        /// 操作单号，后续回调和查询划拨结果是需要带过来
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 等于请求参数中的外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
