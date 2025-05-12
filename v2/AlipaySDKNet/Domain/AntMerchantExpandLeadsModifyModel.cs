using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandLeadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandLeadsModifyModel : AopObject
    {
        /// <summary>
        /// leads详细地址信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商户品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 需通过ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("business_license_key")]
        public string BusinessLicenseKey { get; set; }

        /// <summary>
        /// 城市编码。 请按照蚂蚁店铺地区码 表格中填写表格中内容填写。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// leads设备铺设个数
        /// </summary>
        [XmlElement("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 区县编码。 请按照蚂蚁店铺地区码 表格中填写。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 地理信息纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// leadsId,leads业务主键信息
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// leads名称
        /// </summary>
        [XmlElement("leads_name")]
        public string LeadsName { get; set; }

        /// <summary>
        /// 地理信息经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 类目标准一级类目。类目标准及与原类目映射关系参见 支付宝门店类目-最新 表格。
        /// </summary>
        [XmlElement("mcc_l_1")]
        public string MccL1 { get; set; }

        /// <summary>
        /// 类目标准二级类目。类目标准及与原类目映射关系参见 支付宝门店类目-最新 表格。
        /// </summary>
        [XmlElement("mcc_l_2")]
        public string MccL2 { get; set; }

        /// <summary>
        /// 需通过ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("out_door_pic_oss_key")]
        public string OutDoorPicOssKey { get; set; }

        /// <summary>
        /// 省份编码。 请按照蚂蚁店铺地区码 表格中填写。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 提报主体
        /// </summary>
        [XmlElement("submit_object")]
        public string SubmitObject { get; set; }
    }
}
