using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarRentcarQuotefilterQueryResponse.
    /// </summary>
    public class AlipayEcoMycarRentcarQuotefilterQueryResponse : AopResponse
    {
        /// <summary>
        /// 被过滤的报价信息
        /// </summary>
        [XmlArray("quote_infos")]
        [XmlArrayItem("rent_car_quote_info")]
        public List<RentCarQuoteInfo> QuoteInfos { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
