using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioDataCreateResponse : AopResponse
    {
        /// <summary>
        /// 作品集ID
        /// </summary>
        [XmlElement("portfolio_id")]
        public string PortfolioId { get; set; }
    }
}
