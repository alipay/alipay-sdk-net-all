using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoyaltyDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoyaltyDetailDTO : AopObject
    {
        /// <summary>
        /// 每个阶段对应的分账计划
        /// </summary>
        [XmlArray("royalties")]
        [XmlArrayItem("royalty_d_t_o")]
        public List<RoyaltyDTO> Royalties { get; set; }

        /// <summary>
        /// 阶段号，举例1、2、3.......
        /// </summary>
        [XmlElement("stage_no")]
        public long StageNo { get; set; }
    }
}
