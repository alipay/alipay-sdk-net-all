using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 素材列表
        /// </summary>
        [XmlArray("opuses")]
        [XmlArrayItem("opus_info")]
        public List<OpusInfo> Opuses { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
