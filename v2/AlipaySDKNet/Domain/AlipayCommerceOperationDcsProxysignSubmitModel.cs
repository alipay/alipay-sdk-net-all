using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationDcsProxysignSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationDcsProxysignSubmitModel : AopObject
    {
        /// <summary>
        /// 门店所在位置纬度，小数点后最多保留6位
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店所在位置经度，小数点后最多保留6位
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 详细地址，仅填写“去除省市区”后的地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店所在城市编码。参考民政部最新行政区划编码
        /// </summary>
        [XmlElement("shop_city_code")]
        public string ShopCityCode { get; set; }

        /// <summary>
        /// 门店联系人
        /// </summary>
        [XmlElement("shop_contact")]
        public string ShopContact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("shop_contact_phone")]
        public string ShopContactPhone { get; set; }

        /// <summary>
        /// 门店所在区县编码，参考最新国家行政区划
        /// </summary>
        [XmlElement("shop_district_code")]
        public string ShopDistrictCode { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店所在省份编码。参考民政部最新行政区划编码
        /// </summary>
        [XmlElement("shop_province_code")]
        public string ShopProvinceCode { get; set; }
    }
}
