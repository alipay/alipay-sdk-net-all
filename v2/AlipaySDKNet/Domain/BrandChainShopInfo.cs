using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandChainShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandChainShopInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("inte_op_shop_business_time")]
        public List<InteOpShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 店铺所在城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 店铺联系手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固定电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 店铺详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 店铺所在区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg。 传入使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("out_door_images")]
        public string OutDoorImages { get; set; }

        /// <summary>
        /// 店铺所在省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店品牌
        /// </summary>
        [XmlElement("shop_brand_id")]
        public string ShopBrandId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
