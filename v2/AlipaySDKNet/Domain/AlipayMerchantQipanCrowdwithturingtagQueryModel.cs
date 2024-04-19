using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdwithturingtagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdwithturingtagQueryModel : AopObject
    {
        /// <summary>
        /// 人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群标签池
        /// </summary>
        [XmlArray("crowd_pool_list")]
        [XmlArrayItem("crowd_operation_pool")]
        public List<CrowdOperationPool> CrowdPoolList { get; set; }
    }
}
