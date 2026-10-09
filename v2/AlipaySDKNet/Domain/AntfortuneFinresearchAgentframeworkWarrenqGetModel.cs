using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchAgentframeworkWarrenqGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchAgentframeworkWarrenqGetModel : AopObject
    {
        /// <summary>
        /// 查询结果需要的requst_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
