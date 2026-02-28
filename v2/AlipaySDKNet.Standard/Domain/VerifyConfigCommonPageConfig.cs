using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyConfigCommonPageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyConfigCommonPageConfig : AopObject
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [XmlElement("back_ground_image")]
        public string BackGroundImage { get; set; }

        /// <summary>
        /// 半浮层透明度，格式为整数百分比
        /// </summary>
        [XmlElement("float_diaphaneity")]
        public long FloatDiaphaneity { get; set; }
    }
}
