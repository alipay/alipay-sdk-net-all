using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderServicePackageVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderServicePackageVO : AopObject
    {
        /// <summary>
        /// 用户实付金额(分)
        /// </summary>
        [XmlElement("amount_user")]
        public long AmountUser { get; set; }

        /// <summary>
        /// 是否支持用户申请退款
        /// </summary>
        [XmlElement("can_refund")]
        public bool CanRefund { get; set; }

        /// <summary>
        /// 绑定医生团队ID
        /// </summary>
        [XmlElement("doctor_team_id")]
        public string DoctorTeamId { get; set; }

        /// <summary>
        /// 履约有效天数
        /// </summary>
        [XmlElement("fulfillment_valid_days")]
        public long FulfillmentValidDays { get; set; }

        /// <summary>
        /// 领衔医生ID
        /// </summary>
        [XmlElement("lead_doctor_id")]
        public string LeadDoctorId { get; set; }

        /// <summary>
        /// 服务包订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 服务包订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public ServicepackagePatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 用户支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 退款信息
        /// </summary>
        [XmlElement("refund_info")]
        public ServicepackageRefundInfo RefundInfo { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_package_items")]
        [XmlArrayItem("service_package_item")]
        public List<ServicePackageItem> ServicePackageItems { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }

        /// <summary>
        /// 服务包价格（分）
        /// </summary>
        [XmlElement("service_package_price")]
        public long ServicePackagePrice { get; set; }

        /// <summary>
        /// 权益有效期截止时间
        /// </summary>
        [XmlElement("service_package_time")]
        public string ServicePackageTime { get; set; }
    }
}
