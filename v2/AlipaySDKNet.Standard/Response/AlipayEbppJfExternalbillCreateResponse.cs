using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfExternalbillCreateResponse.
    /// </summary>
    public class AlipayEbppJfExternalbillCreateResponse : AopResponse
    {
        /// <summary>
        /// 交易明细
        /// </summary>
        [XmlElement("trade_detail")]
        public PucExternalOrderDetailInfo TradeDetail { get; set; }
    }
}
