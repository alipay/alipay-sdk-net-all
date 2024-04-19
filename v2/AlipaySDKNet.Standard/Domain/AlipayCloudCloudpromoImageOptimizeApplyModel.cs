using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoImageOptimizeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoImageOptimizeApplyModel : AopObject
    {
        /// <summary>
        /// 背景图片地址
        /// </summary>
        [XmlElement("background")]
        public string Background { get; set; }

        /// <summary>
        /// 图片的高度像素，默认512
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 图片url地址列表，最大支持20张图片地址
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 参考开放平台行业类目的一级-二级-三级类目，多级以”-“连接
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 模板ID用于指定优化方案（非必传） 人像漫改可用模板id：portrait_STYLE_makotoshinkai-single（新海诚）、portrait_STYLE_coloredPencil-single（彩铅）、portrait_STYLE_miyazakihayao-single（宫崎骏）、portrait_STYLE_cyberpunk（赛博朋克）
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 图片的宽度像素，默认512
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
