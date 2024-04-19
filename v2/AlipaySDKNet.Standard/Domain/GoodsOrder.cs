using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsOrder Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsOrder : AopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片素材Id
        /// </summary>
        [XmlElement("goods_picture_id")]
        public string GoodsPictureId { get; set; }
    }
}
