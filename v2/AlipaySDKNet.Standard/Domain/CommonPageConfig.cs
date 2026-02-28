using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonPageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class CommonPageConfig : AopObject
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [XmlElement("background_image")]
        public string BackgroundImage { get; set; }

        /// <summary>
        /// 半浮层透明度，整数百分比形式
        /// </summary>
        [XmlElement("float_diaphaneity")]
        public long FloatDiaphaneity { get; set; }
    }
}
