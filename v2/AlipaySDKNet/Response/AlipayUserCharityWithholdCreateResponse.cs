using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCharityWithholdCreateResponse.
    /// </summary>
    public class AlipayUserCharityWithholdCreateResponse : AopResponse
    {
        /// <summary>
        /// 代扣结果 WITHHOLD_INPROCESS 代扣中 WITHHOLD_SUCCESS 代扣成功 WITHHOLD_FAIL 代扣失败
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 爱心捐赠的交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
