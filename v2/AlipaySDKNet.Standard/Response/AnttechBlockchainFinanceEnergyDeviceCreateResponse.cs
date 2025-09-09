using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceEnergyDeviceCreateResponse.
    /// </summary>
    public class AnttechBlockchainFinanceEnergyDeviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 负荷资源实体Id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 负荷资源实体状态
        /// </summary>
        [XmlElement("entity_status")]
        public string EntityStatus { get; set; }
    }
}
