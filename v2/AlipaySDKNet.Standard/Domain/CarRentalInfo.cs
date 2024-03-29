using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalInfo : AopObject
    {
        /// <summary>
        /// 计费开始时间
        /// </summary>
        [XmlElement("billing_start_time")]
        public string BillingStartTime { get; set; }

        /// <summary>
        /// 已行驶时长(单位为分钟)
        /// </summary>
        [XmlElement("driving_duration")]
        public long DrivingDuration { get; set; }

        /// <summary>
        /// 已行驶里程(单位为米)
        /// </summary>
        [XmlElement("driving_mileage")]
        public long DrivingMileage { get; set; }

        /// <summary>
        /// 时长单价(实时单非套餐必填)
        /// </summary>
        [XmlElement("duration_unit_price")]
        public string DurationUnitPrice { get; set; }

        /// <summary>
        /// 租借预计结束时间(预约单必填)
        /// </summary>
        [XmlElement("estimate_lease_end_time")]
        public string EstimateLeaseEndTime { get; set; }

        /// <summary>
        /// 租借预计开始时间(预约单必填)
        /// </summary>
        [XmlElement("estimate_lease_start_time")]
        public string EstimateLeaseStartTime { get; set; }

        /// <summary>
        /// 可免费取消时长(单位为分钟)
        /// </summary>
        [XmlElement("free_cancellation_time")]
        public long FreeCancellationTime { get; set; }

        /// <summary>
        /// 里程单价(实时单套餐必填)
        /// </summary>
        [XmlElement("mileage_unit_price")]
        public string MileageUnitPrice { get; set; }

        /// <summary>
        /// 套餐包含时长(单位为分钟)  用于区分是否为套餐,非套餐场景时当前值为0
        /// </summary>
        [XmlElement("package_duration")]
        public long PackageDuration { get; set; }

        /// <summary>
        /// 套餐包含里程(单位为米)
        /// </summary>
        [XmlElement("package_mileage")]
        public long PackageMileage { get; set; }

        /// <summary>
        /// 套餐名称(实时单套餐必填)
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 租借实际结束时间
        /// </summary>
        [XmlElement("real_lease_end_time")]
        public string RealLeaseEndTime { get; set; }

        /// <summary>
        /// 租借实际开始时间
        /// </summary>
        [XmlElement("real_lease_start_time")]
        public string RealLeaseStartTime { get; set; }

        /// <summary>
        /// 还车门店ID(预约单必填)
        /// </summary>
        [XmlElement("shopid_car_return")]
        public string ShopidCarReturn { get; set; }

        /// <summary>
        /// 取车门店ID(预约单必填)
        /// </summary>
        [XmlElement("shopid_car_taken")]
        public string ShopidCarTaken { get; set; }

        /// <summary>
        /// 限额上限(超过部分需要先支付)
        /// </summary>
        [XmlElement("upper_limit_amount")]
        public string UpperLimitAmount { get; set; }
    }
}
