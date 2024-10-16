using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarRentcarQuoteadvQueryResponse.
    /// </summary>
    public class AlipayEcoMycarRentcarQuoteadvQueryResponse : AopResponse
    {
        /// <summary>
        /// 报价优势率信息
        /// </summary>
        [XmlArray("quote_infos")]
        [XmlArrayItem("rent_car_quote_info")]
        public List<RentCarQuoteInfo> QuoteInfos { get; set; }

        /// <summary>
        /// 报价总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
