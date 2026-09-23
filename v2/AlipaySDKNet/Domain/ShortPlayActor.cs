using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayActor Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayActor : AopObject
    {
        /// <summary>
        /// 演员名，最长 30 个字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 演员照片临时 material_id。
        /// </summary>
        [XmlElement("photo_material_id")]
        public string PhotoMaterialId { get; set; }

        /// <summary>
        /// 演员简介，最长 100 个字
        /// </summary>
        [XmlElement("profile")]
        public string Profile { get; set; }

        /// <summary>
        /// 饰演角色名，最长 30 个字
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
