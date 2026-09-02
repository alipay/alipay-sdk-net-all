using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItem : AopObject
    {
        /// <summary>
        /// 是否支持顾问代下
        /// </summary>
        [XmlElement("advisor_proxy")]
        public bool AdvisorProxy { get; set; }

        /// <summary>
        /// 折扣：8.0表示8折
        /// </summary>
        [XmlElement("discounted")]
        public string Discounted { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 是否为免费
        /// </summary>
        [XmlElement("free")]
        public bool Free { get; set; }

        /// <summary>
        /// 好大夫skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 服务时长,单位见service_duration_unit字段
        /// </summary>
        [XmlElement("service_duration")]
        public string ServiceDuration { get; set; }

        /// <summary>
        /// 服务时长单位（如：天/小时/分钟）
        /// </summary>
        [XmlElement("service_duration_unit")]
        public string ServiceDurationUnit { get; set; }

        /// <summary>
        /// 服务项id
        /// </summary>
        [XmlElement("service_package_item_id")]
        public string ServicePackageItemId { get; set; }

        /// <summary>
        /// SaaS skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 服务子项id N选M场景需求
        /// </summary>
        [XmlElement("sub_package_item_id")]
        public string SubPackageItemId { get; set; }
    }
}
