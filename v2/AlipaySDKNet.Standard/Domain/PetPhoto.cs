using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetPhoto Data Structure.
    /// </summary>
    [Serializable]
    public class PetPhoto : AopObject
    {
        /// <summary>
        /// 宠物照片类型， NOSE("nose", "鼻纹照"), FACE("face", "正脸照");
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 宠物照片地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
