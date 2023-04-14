using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoCreateSource Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoCreateSource : AopObject
    {
        /// <summary>
        /// 小程序源码地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 调用闪蝶基于小程序源码创建应用时对应调用方侧应用的唯一标识
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
