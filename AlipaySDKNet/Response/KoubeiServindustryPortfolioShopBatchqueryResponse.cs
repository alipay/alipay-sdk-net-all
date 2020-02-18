using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioShopBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioShopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("portfolio_count")]
        public long PortfolioCount { get; set; }

        /// <summary>
        /// 返回作品集列表
        /// </summary>
        [XmlArray("portfolio_info_list")]
        [XmlArrayItem("portfolio_info_open_model")]
        public List<PortfolioInfoOpenModel> PortfolioInfoList { get; set; }
    }
}
