using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateResponse : AopResponse
    {
        /// <summary>
        /// 作品列表
        /// </summary>
        [XmlElement("opuses")]
        public OpusCreateResponse Opuses { get; set; }
    }
}
