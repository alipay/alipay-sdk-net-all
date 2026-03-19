using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePayinfoSyncResponse.
    /// </summary>
    public class AlipayTradePayinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
