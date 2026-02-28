using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuranceMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuranceMaterialInfo : AopObject
    {
        /// <summary>
        /// 材料内容
        /// </summary>
        [XmlElement("material_content")]
        public string MaterialContent { get; set; }

        /// <summary>
        /// 材料描述
        /// </summary>
        [XmlElement("material_desc")]
        public string MaterialDesc { get; set; }

        /// <summary>
        /// 材料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }
    }
}
