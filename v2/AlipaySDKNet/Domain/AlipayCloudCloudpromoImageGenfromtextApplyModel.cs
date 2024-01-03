using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoImageGenfromtextApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoImageGenfromtextApplyModel : AopObject
    {
        /// <summary>
        /// 图片的高度像素
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 生成图片的数量，限制在1-4之间
        /// </summary>
        [XmlElement("image_num")]
        public long ImageNum { get; set; }

        /// <summary>
        /// 参考开放平台行业类目的一级-二级-三级类目，多级以”-“连接
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 不希望出现在图片里的内容
        /// </summary>
        [XmlElement("negative_prompt")]
        public string NegativePrompt { get; set; }

        /// <summary>
        /// 外部业务号，做幂等id使用
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 生成图片的提示词
        /// </summary>
        [XmlElement("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// 图片的宽度像素
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
