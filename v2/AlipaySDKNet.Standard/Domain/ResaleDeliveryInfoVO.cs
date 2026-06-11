using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResaleDeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResaleDeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 收件人详细收货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收件人区
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 收件人区
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_bill_no")]
        public string LogisticsBillNo { get; set; }

        /// <summary>
        /// 物流平台
        /// </summary>
        [XmlElement("logistics_platform")]
        public string LogisticsPlatform { get; set; }

        /// <summary>
        /// 收件人联系电话
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收件人省
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
