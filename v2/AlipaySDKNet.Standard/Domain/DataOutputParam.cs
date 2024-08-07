using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataOutputParam Data Structure.
    /// </summary>
    [Serializable]
    public class DataOutputParam : AopObject
    {
        /// <summary>
        /// 不同的枚举对应的值不一样，如果是风险标签类是Y或N，用户的异常状态、url网址等信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 只是一个枚举值，譬如00代表是否风险灰名单  01代表是否有新签风险 02 代表赌博庄家等
        /// </summary>
        [XmlElement("property")]
        public string Property { get; set; }
    }
}
