using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderOnsettleQueryResponse.
    /// </summary>
    public class AlipayTradeOrderOnsettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 剩余可分金额
        /// </summary>
        [XmlElement("unsettled_amount")]
        public string UnsettledAmount { get; set; }
    }
}
