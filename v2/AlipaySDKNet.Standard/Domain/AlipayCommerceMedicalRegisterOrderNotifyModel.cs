using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterOrderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterOrderNotifyModel : AopObject
    {
        /// <summary>
        /// 订单创建 INSERT, 状态同步 UPDATE, 订单删除 DELETE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 挂号预约的时间段
        /// </summary>
        [XmlElement("appoint_part")]
        public string AppointPart { get; set; }

        /// <summary>
        /// 订单取消的原因，可能是用户取消，系统取消，或者医生自定义取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 订单取消时间 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 渠道，CHANNEL_SEARCH_REGISTER:挂号频道;AN_ZHEN_ER_REGISTER:安诊儿;HEALTH_BUTLER_REGISTER:健康管家
        /// </summary>
        [XmlElement("channle")]
        public string Channle { get; set; }

        /// <summary>
        /// （号源）就诊时段结束时间，HH:mm
        /// </summary>
        [XmlElement("clinic_end_time")]
        public string ClinicEndTime { get; set; }

        /// <summary>
        /// （号源）就诊时段开始时间，HH:mm
        /// </summary>
        [XmlElement("clinic_start_time")]
        public string ClinicStartTime { get; set; }

        /// <summary>
        /// 就诊时间，时间格式：HH:mm
        /// </summary>
        [XmlElement("clinic_time")]
        public string ClinicTime { get; set; }

        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 挂号费用，单位：分
        /// </summary>
        [XmlElement("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// 医院唯一编码
        /// </summary>
        [XmlElement("hospital_code")]
        public string HospitalCode { get; set; }

        /// <summary>
        /// 医院的号源编码
        /// </summary>
        [XmlElement("hospital_number_no")]
        public string HospitalNumberNo { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("isv_hos_dept_name")]
        public string IsvHosDeptName { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("isv_hos_name")]
        public string IsvHosName { get; set; }

        /// <summary>
        /// 服务商用户id
        /// </summary>
        [XmlElement("isv_user_id")]
        public string IsvUserId { get; set; }

        /// <summary>
        /// 号源ID
        /// </summary>
        [XmlElement("number_id")]
        public string NumberId { get; set; }

        /// <summary>
        /// 号源序号
        /// </summary>
        [XmlElement("number_seq_no")]
        public string NumberSeqNo { get; set; }

        /// <summary>
        /// order_no
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 挂号订单属性
        /// </summary>
        [XmlElement("order_prop")]
        public string OrderProp { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 就诊人id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 支付时间 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式，
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 统一分配，接入的时候传固定的平台编码。
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 号源日期：格式 yyyyMMdd
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        [XmlElement("shift_type")]
        public string ShiftType { get; set; }
    }
}
