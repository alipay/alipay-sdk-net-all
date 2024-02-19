using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdwithturingtagCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdwithturingtagCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群id，人群加工必选
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 圈选的标签集合
        /// </summary>
        [XmlArray("crowd_pool_list")]
        [XmlArrayItem("crowd_operation_pool")]
        public List<CrowdOperationPool> CrowdPoolList { get; set; }
    }
}
