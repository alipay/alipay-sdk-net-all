using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyEntityCreateResponse.
    /// </summary>
    public class AnttechBlockchainFinanceEnergyEntityCreateResponse : AopResponse
    {
        /// <summary>
        /// 数科系统中的实体Id， 唯一
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 可信实体状态
        /// </summary>
        [XmlElement("entity_status")]
        public string EntityStatus { get; set; }
    }
}
