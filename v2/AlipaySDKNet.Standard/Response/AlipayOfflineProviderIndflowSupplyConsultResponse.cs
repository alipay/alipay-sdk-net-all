using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndflowSupplyConsultResponse.
    /// </summary>
    public class AlipayOfflineProviderIndflowSupplyConsultResponse : AopResponse
    {
        /// <summary>
        /// 展位ID
        /// </summary>
        [XmlElement("out_pos_id")]
        public string OutPosId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("supplies")]
        [XmlArrayItem("supply_item_d_t_o")]
        public List<SupplyItemDTO> Supplies { get; set; }

        /// <summary>
        /// 供给数量，单位：个
        /// </summary>
        [XmlElement("supply_count")]
        public long SupplyCount { get; set; }
    }
}
