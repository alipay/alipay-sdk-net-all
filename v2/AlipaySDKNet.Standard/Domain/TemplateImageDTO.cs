using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateImageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateImageDTO : AopObject
    {
        /// <summary>
        /// logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片获得图片ID。图片需在1M以内，支持bmp、png、jpeg、jpg、gif格式，尺寸不小于500*500px的正方形，请优先使用商家LOGO。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 背景图片ID，通过接口（alipay.offline.material.image.upload）上传图片获得图片ID。图片需在1M以内，支持bmp、png、jpeg、jpg、gif格式，尺寸不小于1020*643px，不得有圆角，不得拉伸变形。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("strip")]
        public string Strip { get; set; }
    }
}
