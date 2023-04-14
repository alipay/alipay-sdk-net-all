using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarFuellingShopQueryResponse.
    /// </summary>
    public class AlipayEcoMycarFuellingShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 国标6位城市编号
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 国标6位区编号
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 纬度，高德坐标系，最好找到高德POI标识，取得标识的维度填入
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度，高德坐标系,最好找到高德POI标识，取得标识的经度填入
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// ISV提供的门店支付链接地址，如果支付链接地址为空，默认使用用户的当面付链接地址。注意：链接地址必须使用https://或alipays://协议。
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 高德POI信息唯一ID
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 商品信息集合，JSON格式
        /// </summary>
        [XmlArray("product")]
        [XmlArrayItem("product")]
        public List<Product> Product { get; set; }

        /// <summary>
        /// 国标6位省份编号
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 促销信息集合，JSON格式
        /// </summary>
        [XmlArray("sale")]
        [XmlArrayItem("sale")]
        public List<Sale> Sale { get; set; }

        /// <summary>
        /// 车主平台内部门店编号
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态，0：有效；1：停用；
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }
    }
}
