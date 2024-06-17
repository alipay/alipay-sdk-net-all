using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQipanCrowdoperationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQipanCrowdoperationCreateModel : AopObject
    {
        /// <summary>
        /// 人群名称不可重复
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 根据传入的计算组合生产人群，支持两种模式：标签圈选（计算组合节点都为标签）、组合人群（计算组合组合都为人群）
        /// </summary>
        [XmlArray("operation_pool_list")]
        [XmlArrayItem("open_crowd_operation_pool_request")]
        public List<OpenCrowdOperationPoolRequest> OperationPoolList { get; set; }
    }
}
