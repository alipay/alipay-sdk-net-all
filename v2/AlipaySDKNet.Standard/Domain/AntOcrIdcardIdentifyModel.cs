using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntOcrIdcardIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntOcrIdcardIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 正面：face；背面：back
        /// </summary>
        [XmlElement("side")]
        public string Side { get; set; }

        /// <summary>
        /// 图片存储类型，url：图片url地址；aftsId：afts文件服务Id
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
