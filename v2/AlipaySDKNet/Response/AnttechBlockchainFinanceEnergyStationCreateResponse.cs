using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyStationCreateResponse.
    /// </summary>
    public class AnttechBlockchainFinanceEnergyStationCreateResponse : AopResponse
    {
        /// <summary>
        /// 站点实体ID
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 站点实体状态
        /// </summary>
        [XmlElement("entity_status")]
        public string EntityStatus { get; set; }
    }
}
