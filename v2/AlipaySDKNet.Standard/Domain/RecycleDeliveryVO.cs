using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeliveryVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeliveryVO : AopObject
    {
        /// <summary>
        /// 实际取件时间
        /// </summary>
        [XmlElement("actual_time")]
        public string ActualTime { get; set; }

        /// <summary>
        /// INIT：待分配 ；ASSIGNED:已分配小二；TRAVELING：运输中；FINISHED：已完成
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// EXPRESS商家邮寄;DOOR_TO_DOOR工程师上门;USER_EXPRESS自寄;TO_STORE到店
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 预约结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 物流彪马
        /// </summary>
        [XmlElement("logistic_bill_no")]
        public string LogisticBillNo { get; set; }

        /// <summary>
        /// 物流公司
        /// </summary>
        [XmlElement("logistic_platform")]
        public string LogisticPlatform { get; set; }

        /// <summary>
        /// 小哥联系方式
        /// </summary>
        [XmlElement("staff_phone")]
        public string StaffPhone { get; set; }

        /// <summary>
        /// 预约开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户不卖了的收货地址
        /// </summary>
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 用户联系方式
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
