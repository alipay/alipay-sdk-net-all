using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UploadMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class UploadMaterial : AopObject
    {
        /// <summary>
        /// 元素C端渲染关联位置key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 创意或交互动作图片/视频物料URL
        /// </summary>
        [XmlElement("material")]
        public string Material { get; set; }

        /// <summary>
        /// IMG-图片 VIDEO-视频
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
