using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlgorithmGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlgorithmGoodsInfo : AopObject
    {
        /// <summary>
        /// 算法商品Id
        /// </summary>
        [XmlElement("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// gif文件Id
        /// </summary>
        [XmlElement("gif_file_id")]
        public string GifFileId { get; set; }

        /// <summary>
        /// 图片文件Id
        /// </summary>
        [XmlElement("pic_file_id")]
        public string PicFileId { get; set; }

        /// <summary>
        /// 商品三维(单位mm*mm*mm)
        /// </summary>
        [XmlElement("three_dimension")]
        public string ThreeDimension { get; set; }

        /// <summary>
        /// 缩略图fileId表，json
        /// </summary>
        [XmlElement("thumbnails")]
        public string Thumbnails { get; set; }
    }
}
