using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataIotdataIdpsolutionProductpriceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataIdpsolutionProductpriceQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品一级分类
        /// </summary>
        [XmlElement("category_name_1")]
        public string CategoryName1 { get; set; }

        /// <summary>
        /// 商品二级分类
        /// </summary>
        [XmlElement("category_name_2")]
        public string CategoryName2 { get; set; }

        /// <summary>
        /// 商品三级分类
        /// </summary>
        [XmlElement("category_name_3")]
        public string CategoryName3 { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 纬度 当前字段已废弃(有location替代参数)
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 设备经纬度。device_sn、shop_id、 location三选一必填
        /// </summary>
        [XmlElement("location")]
        public DeviceLocation Location { get; set; }

        /// <summary>
        /// 经度 当前字段已废弃(有location替代参数)
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 店铺唯一ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品长宽高
        /// </summary>
        [XmlElement("size")]
        public ProductSize Size { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }
    }
}
