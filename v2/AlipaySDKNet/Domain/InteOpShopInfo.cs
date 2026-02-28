using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpShopInfo : AopObject
    {
        /// <summary>
        /// 门店城市编码。
        /// </summary>
        [XmlElement("shop_city_code")]
        public string ShopCityCode { get; set; }

        /// <summary>
        /// 门店所在国家编码。中国默认156。
        /// </summary>
        [XmlElement("shop_country_code")]
        public string ShopCountryCode { get; set; }

        /// <summary>
        /// 门店详细地址。
        /// </summary>
        [XmlElement("shop_detail_address")]
        public string ShopDetailAddress { get; set; }

        /// <summary>
        /// 门店区县编码。
        /// </summary>
        [XmlElement("shop_district_code")]
        public string ShopDistrictCode { get; set; }

        /// <summary>
        /// 门店名称。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店所在省份编码。
        /// </summary>
        [XmlElement("shop_province_code")]
        public string ShopProvinceCode { get; set; }

        /// <summary>
        /// 门店内景图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg。 传入alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("shop_scene_pic")]
        public string ShopScenePic { get; set; }

        /// <summary>
        /// 门店门头照图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg。 传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("shop_sign_board_pic")]
        public string ShopSignBoardPic { get; set; }
    }
}
