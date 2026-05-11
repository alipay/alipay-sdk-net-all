using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryInfoParam : AopObject
    {
        /// <summary>
        /// 额外赠送次数
        /// </summary>
        [XmlElement("gift_num")]
        public long GiftNum { get; set; }

        /// <summary>
        /// 医院城市
        /// </summary>
        [XmlElement("hospital_city")]
        public string HospitalCity { get; set; }

        /// <summary>
        /// 医院级别，文本展示非枚举类型
        /// </summary>
        [XmlElement("hospital_level")]
        public string HospitalLevel { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// 产品场景
        /// </summary>
        [XmlElement("product_scene")]
        public string ProductScene { get; set; }

        /// <summary>
        /// 服务说明
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 服务时长，分、小时、天、月、年
        /// </summary>
        [XmlElement("service_time")]
        public string ServiceTime { get; set; }

        /// <summary>
        /// 服务时长单位，分、小时、天、月、年
        /// </summary>
        [XmlElement("service_time_unit")]
        public string ServiceTimeUnit { get; set; }

        /// <summary>
        /// 是否展示服务适用情况
        /// </summary>
        [XmlElement("show_applicability")]
        public string ShowApplicability { get; set; }

        /// <summary>
        /// SKU标签
        /// </summary>
        [XmlElement("sku_tag")]
        public string SkuTag { get; set; }

        /// <summary>
        /// 服务提供者
        /// </summary>
        [XmlElement("supplier")]
        public string Supplier { get; set; }
    }
}
