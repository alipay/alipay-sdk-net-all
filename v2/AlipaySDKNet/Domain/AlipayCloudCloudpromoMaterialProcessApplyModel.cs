using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMaterialProcessApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMaterialProcessApplyModel : AopObject
    {
        /// <summary>
        /// 图片的高度像素，默认750
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 图片url地址列表，最大暂时支持10张图片地址
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 外部业务号，作为幂等ID使用
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 素材处理场景，取以下枚举值： WHITE_BACKGROUND（商品图白底化处理）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 模板id，用于指定背景优化方案（非必传）
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 图片的宽度像素，默认750
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
