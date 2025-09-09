using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeDeleteFailDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeDeleteFailDetail : AopObject
    {
        /// <summary>
        /// 外部平台导入广告库，广告投放创意对应的外部资源ID
        /// </summary>
        [XmlElement("creative_outer_id")]
        public string CreativeOuterId { get; set; }

        /// <summary>
        /// 详细的失败信息
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }
    }
}
