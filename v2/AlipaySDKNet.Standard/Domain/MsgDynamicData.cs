using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgDynamicData Data Structure.
    /// </summary>
    [Serializable]
    public class MsgDynamicData : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("dynamic_type")]
        public string DynamicType { get; set; }

        /// <summary>
        /// 动态内容值
        /// </summary>
        [XmlElement("dynamic_value")]
        public string DynamicValue { get; set; }
    }
}
