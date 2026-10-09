using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbDrawSize Data Structure.
    /// </summary>
    [Serializable]
    public class NbDrawSize : AopObject
    {
        /// <summary>
        /// 图片高度，单位像素
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 图片宽度，单位像素
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
