using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FunImageWeshineItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FunImageWeshineItemDetail : AopObject
    {
        /// <summary>
        /// 闪萌表情包查询接口返回的表情包gif图片地址
        /// </summary>
        [XmlElement("gif")]
        public string Gif { get; set; }

        /// <summary>
        /// 闪萌表情包图片宽度
        /// </summary>
        [XmlElement("h")]
        public long H { get; set; }

        /// <summary>
        /// 闪萌表情包图片宽度
        /// </summary>
        [XmlElement("w")]
        public long W { get; set; }

        /// <summary>
        /// 闪萌表情包webp格式链接
        /// </summary>
        [XmlElement("webp")]
        public string Webp { get; set; }
    }
}
