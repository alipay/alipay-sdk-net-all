using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedicineShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店所在位置的详细地址，需精确到门牌号
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店营业状态
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 多个时间段按当天的从早到晚顺序，不能重叠、不能跨天；最多5个时间段
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("medical_shop_time_period")]
        public List<MedicalShopTimePeriod> BusinessTime { get; set; }

        /// <summary>
        /// 门店所在城市编码。参考<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">蚂蚁店铺地区码</a>
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店配送配置信息；最多支持5个配送配置信息
        /// </summary>
        [XmlArray("delivery_info")]
        [XmlArrayItem("medical_shop_delivery_info")]
        public List<MedicalShopDeliveryInfo> DeliveryInfo { get; set; }

        /// <summary>
        /// 门店所在区县编码。参考<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">蚂蚁店铺地区码</a>
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 火星坐标系标准
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 火星坐标系标准
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店营销活动
        /// </summary>
        [XmlArray("marketing_activity")]
        [XmlArrayItem("medical_shop_marketing_activity")]
        public List<MedicalShopMarketingActivity> MarketingActivity { get; set; }

        /// <summary>
        /// 国家医保局最新标准的定点医药机构编码
        /// </summary>
        [XmlElement("medical_org_no")]
        public string MedicalOrgNo { get; set; }

        /// <summary>
        /// 外部门店Id
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// 高德地图poiid
        /// </summary>
        [XmlElement("poiid")]
        public string Poiid { get; set; }

        /// <summary>
        /// 门店所在省份编码。参考<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">蚂蚁店铺地区码</a>
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店经营类目
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 支付宝门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 通过<a href="https://opendocs.alipay.com/mini/3fade898_alipay.marketing.image.enhance.upload">alipay.marketing.image.enhance.upload</a>接口上传图片后获取文件Id
        /// </summary>
        [XmlElement("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// 门店完整名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店标签列表
        /// </summary>
        [XmlArray("shop_tags")]
        [XmlArrayItem("medical_shop_tag")]
        public List<MedicalShopTag> ShopTags { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 支付宝小程序URL
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }
    }
}
