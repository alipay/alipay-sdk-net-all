using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarSubscriptionDeduction Data Structure.
    /// </summary>
    [Serializable]
    public class CarSubscriptionDeduction : AopObject
    {
        /// <summary>
        /// 车辆押金扣款（元）
        /// </summary>
        [XmlElement("car_deposit_deduct_amount")]
        public string CarDepositDeductAmount { get; set; }

        /// <summary>
        /// 实际分佣金额（元）
        /// </summary>
        [XmlElement("rental_fee_commission")]
        public string RentalFeeCommission { get; set; }

        /// <summary>
        /// 实际扣款金额（元）
        /// </summary>
        [XmlElement("rental_fee_deduct_amount")]
        public string RentalFeeDeductAmount { get; set; }

        /// <summary>
        /// 实际扣款金额的组成部分：基础费（元）
        /// </summary>
        [XmlElement("rental_fee_deduct_amount_of_basic")]
        public string RentalFeeDeductAmountOfBasic { get; set; }

        /// <summary>
        /// 实际扣款金额的组成部分：保险费（元）
        /// </summary>
        [XmlElement("rental_fee_deduct_amount_of_insurance")]
        public string RentalFeeDeductAmountOfInsurance { get; set; }

        /// <summary>
        /// 实际扣款金额的组成部分：里程费（元）
        /// </summary>
        [XmlElement("rental_fee_deduct_amount_of_mileage")]
        public string RentalFeeDeductAmountOfMileage { get; set; }

        /// <summary>
        /// 实际扣款金额的组成部分：指标费（元）
        /// </summary>
        [XmlElement("rental_fee_deduct_amount_of_quota")]
        public string RentalFeeDeductAmountOfQuota { get; set; }

        /// <summary>
        /// 扣款期数
        /// </summary>
        [XmlElement("rental_fee_deduct_round")]
        public long RentalFeeDeductRound { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("rental_fee_deduct_status")]
        public string RentalFeeDeductStatus { get; set; }

        /// <summary>
        /// 当期扣款时间
        /// </summary>
        [XmlElement("rental_fee_deduct_time")]
        public string RentalFeeDeductTime { get; set; }

        /// <summary>
        /// 违章押金扣款（元）
        /// </summary>
        [XmlElement("traffic_violation_deposit_deduct_amount")]
        public string TrafficViolationDepositDeductAmount { get; set; }
    }
}
