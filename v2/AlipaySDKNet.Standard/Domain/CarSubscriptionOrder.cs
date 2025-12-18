using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarSubscriptionOrder Data Structure.
    /// </summary>
    [Serializable]
    public class CarSubscriptionOrder : AopObject
    {
        /// <summary>
        /// 车辆押金（元）
        /// </summary>
        [XmlElement("car_deposit")]
        public string CarDeposit { get; set; }

        /// <summary>
        /// 保险金额（元）
        /// </summary>
        [XmlElement("insurance_premium")]
        public string InsurancePremium { get; set; }

        /// <summary>
        /// 大定金额（元）
        /// </summary>
        [XmlElement("large_deposit_amount")]
        public string LargeDepositAmount { get; set; }

        /// <summary>
        /// 单位订阅周期租金（元）
        /// </summary>
        [XmlElement("rental_fee_per_period")]
        public string RentalFeePerPeriod { get; set; }

        /// <summary>
        /// 单位订阅周期租金的组成部分：基础费（元）
        /// </summary>
        [XmlElement("rental_fee_per_period_of_basic")]
        public string RentalFeePerPeriodOfBasic { get; set; }

        /// <summary>
        /// 单位订阅周期租金的组成部分：保险费（元）
        /// </summary>
        [XmlElement("rental_fee_per_period_of_insurance")]
        public string RentalFeePerPeriodOfInsurance { get; set; }

        /// <summary>
        /// 单位订阅周期租金的组成部分：里程费（元）
        /// </summary>
        [XmlElement("rental_fee_per_period_of_mileage")]
        public string RentalFeePerPeriodOfMileage { get; set; }

        /// <summary>
        /// 单位订阅周期租金的组成部分：指标费（元）
        /// </summary>
        [XmlElement("rental_fee_per_period_of_quota")]
        public string RentalFeePerPeriodOfQuota { get; set; }

        /// <summary>
        /// 小订金额（元）
        /// </summary>
        [XmlElement("small_deposit_amount")]
        public string SmallDepositAmount { get; set; }

        /// <summary>
        /// 订阅周期时长
        /// </summary>
        [XmlElement("subscription_duration")]
        public string SubscriptionDuration { get; set; }

        /// <summary>
        /// 订阅周期单位（ChronoUnit）
        /// </summary>
        [XmlElement("subscription_duration_unit")]
        public string SubscriptionDurationUnit { get; set; }

        /// <summary>
        /// 订阅里程（km）
        /// </summary>
        [XmlElement("subscription_mileage")]
        public long SubscriptionMileage { get; set; }

        /// <summary>
        /// 违章押金（元）
        /// </summary>
        [XmlElement("traffic_violation_deposit")]
        public string TrafficViolationDeposit { get; set; }
    }
}
