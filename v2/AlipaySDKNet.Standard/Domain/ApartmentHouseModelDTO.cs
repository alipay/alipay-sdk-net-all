using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApartmentHouseModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApartmentHouseModelDTO : AopObject
    {
        /// <summary>
        /// 公寓房源id
        /// </summary>
        [XmlElement("apartment_house_id")]
        public string ApartmentHouseId { get; set; }

        /// <summary>
        /// 公寓id
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }

        /// <summary>
        /// 入住时间
        /// </summary>
        [XmlElement("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        [XmlElement("deposit")]
        public string Deposit { get; set; }

        /// <summary>
        /// 公寓门牌号
        /// </summary>
        [XmlElement("doorplate_number")]
        public string DoorplateNumber { get; set; }

        /// <summary>
        /// 外部房源id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 是否独卫
        /// </summary>
        [XmlElement("has_private_bathroom")]
        public string HasPrivateBathroom { get; set; }

        /// <summary>
        /// 使用面积(平方米)
        /// </summary>
        [XmlElement("internal_area")]
        public string InternalArea { get; set; }

        /// <summary>
        /// 公寓名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 租金(元)
        /// </summary>
        [XmlElement("rent")]
        public string Rent { get; set; }

        /// <summary>
        /// 租金单位
        /// </summary>
        [XmlElement("rent_unit")]
        public string RentUnit { get; set; }

        /// <summary>
        /// 房源状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("verification_code")]
        public string VerificationCode { get; set; }
    }
}
