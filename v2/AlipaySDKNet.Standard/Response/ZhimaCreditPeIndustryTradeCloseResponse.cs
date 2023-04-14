using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeCloseResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryTradeCloseResponse : AopResponse
    {
        /// <summary>
        /// 传入的资金单号
        /// </summary>
        [XmlElement("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
