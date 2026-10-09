using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemCategoryPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemCategoryPreconsultModel : AopObject
    {
        /// <summary>
        /// 商品详情图的图片ID。文件id通过alipay.open.file.upload 上传资源获取file_id，或通过alipay.marketing.image.enhance.upload获取image_id均可上传成功
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
