using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LackMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class LackMaterial : AopObject
    {
        /// <summary>
        /// 补充材料话术
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 补充材料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }
    }
}
