using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PsychologicalFulfillmentDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class PsychologicalFulfillmentDetailData : AopObject
    {
        /// <summary>
        /// 预约开始时间
        /// </summary>
        [XmlElement("book_time")]
        public string BookTime { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 确认时间（预约成功时必填）
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 咨询师头像
        /// </summary>
        [XmlElement("counseling_avatar")]
        public string CounselingAvatar { get; set; }

        /// <summary>
        /// 咨询师姓名
        /// </summary>
        [XmlElement("counseling_name")]
        public string CounselingName { get; set; }

        /// <summary>
        /// 咨询师职称
        /// </summary>
        [XmlElement("counseling_professional")]
        public string CounselingProfessional { get; set; }

        /// <summary>
        /// 服务类型（比如电话咨询、图文咨询等）
        /// </summary>
        [XmlElement("counseling_type")]
        public string CounselingType { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 履约状态 待预约：PENDING_RESERVE 预约成功：RESERVE_SUCCESS 已取消：CANCELLED 已完成：COMPLETED
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// ISV侧订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 备注（比如异常完成的说明）
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 履约类型，心理权益
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
