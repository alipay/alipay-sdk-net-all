using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutPrCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtPunchoutPrCreateResponse : AopResponse
    {
        /// <summary>
        /// pr下单返回数据
        /// </summary>
        [XmlElement("response_data")]
        public MallReceivePrResponseData ResponseData { get; set; }
    }
}
