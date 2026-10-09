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
        /// 本次退款请求操作，内部受理的操作流水单号 后续退款进度查询通过该字段查询
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 对应本次请求请求参数中的「原路退请求流水号 out_trade_no 」 后续退款进度查询通过该字段查询
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
