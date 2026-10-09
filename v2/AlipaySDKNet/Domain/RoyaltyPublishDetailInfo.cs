using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyPublishDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyPublishDetailInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("royalty_info")]
        [XmlArrayItem("royalty_info_request")]
        public List<RoyaltyInfoRequest> RoyaltyInfo { get; set; }

        /// <summary>
        /// 分账阶段，用于对应分期计划的阶段，正常分期为1，后续需要续租，则依次递增；
        /// </summary>
        [XmlElement("stage_no")]
        public string StageNo { get; set; }
    }
}
