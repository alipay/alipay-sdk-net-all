using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionVostroRefundResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionVostroRefundResponse : AopResponse
    {
        /// <summary>
        /// 内部处理操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求参数中的外部业务流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
