using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeServiceSignResponse.
    /// </summary>
    public class AlipayTradeServiceSignResponse : AopResponse
    {
        /// <summary>
        /// 无限付产品的转入卡信息，服务类型为LARGE_INFINITE时返回。
        /// </summary>
        [XmlElement("large_infinite_card_info")]
        public LargeInfiniteCardInfo LargeInfiniteCardInfo { get; set; }
    }
}
