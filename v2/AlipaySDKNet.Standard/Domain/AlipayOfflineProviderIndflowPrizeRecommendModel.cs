using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndflowPrizeRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndflowPrizeRecommendModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("instance_ids")]
        [XmlArrayItem("string")]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 展位id
        /// </summary>
        [XmlElement("out_pos_id")]
        public string OutPosId { get; set; }
    }
}
