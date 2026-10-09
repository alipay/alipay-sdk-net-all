using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskPullModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateTaskPullModel : AopObject
    {
        /// <summary>
        /// 单次拉取查询的任务数量，默认 100。
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
