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
        /// 商品图片素材Id；商品文件上传接口返回material_id。不传则暂时默认约定图片，具体可以咨询支付宝行业小二
        /// </summary>
        [XmlElement("goods_picture_id")]
        public string GoodsPictureId { get; set; }
    }
}
