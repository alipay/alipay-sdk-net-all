using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoSource Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoSource : AopObject
    {
        /// <summary>
        /// 基于源码的发布流程的源码信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 调用方侧对应应用唯一标识
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
