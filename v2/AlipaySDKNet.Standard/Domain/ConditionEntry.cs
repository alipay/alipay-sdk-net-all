using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConditionEntry Data Structure.
    /// </summary>
    [Serializable]
    public class ConditionEntry : AopObject
    {
        /// <summary>
        /// 纬度的具体key值如workNo ,level
        /// </summary>
        [XmlElement("dim_key")]
        public string DimKey { get; set; }

        /// <summary>
        /// 如维度值是workNo 工号，对应的维度具体信息为具体工号
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
