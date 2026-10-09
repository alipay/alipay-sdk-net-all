using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopTag Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopTag : AopObject
    {
        /// <summary>
        /// 门店标签类型
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }

        /// <summary>
        /// 标签文案，有多个时用英文逗号分隔
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
