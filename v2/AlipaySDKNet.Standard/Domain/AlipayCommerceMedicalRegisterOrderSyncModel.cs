using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterOrderSyncModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 时段
        /// </summary>
        [XmlElement("appoint_part")]
        public string AppointPart { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 订单取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 来源渠道， 健康管家渠道码：HEALTH_BUTLER_REGISTER 安诊儿： AN_ZHEN_ER_REGISTER 挂号频道： CHANNEL_SEARCH_REGISTER SINGLE_HOS_NFYKDZJ 珠江医院（扁鹊单院版）：
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 就诊时段结束时间
        /// </summary>
        [XmlElement("clinic_end_time")]
        public string ClinicEndTime { get; set; }

        /// <summary>
        /// 就诊时段开始时间
        /// </summary>
        [XmlElement("clinic_start_time")]
        public string ClinicStartTime { get; set; }

        /// <summary>
        /// 就诊时间点
        /// </summary>
        [XmlElement("clinic_time")]
        public string ClinicTime { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 挂号费用，单位：分
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 医院号源编码
        /// </summary>
        [XmlElement("hospital_number_no")]
        public string HospitalNumberNo { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 服务商医院科室名称
        /// </summary>
        [XmlElement("isv_hos_dept_name")]
        public string IsvHosDeptName { get; set; }

        /// <summary>
        /// 服务商医院科室ID
        /// </summary>
        [XmlElement("isv_hos_dept_no")]
        public string IsvHosDeptNo { get; set; }

        /// <summary>
        /// 服务商医院名称
        /// </summary>
        [XmlElement("isv_hos_name")]
        public string IsvHosName { get; set; }

        /// <summary>
        /// 服务商医院唯一编码
        /// </summary>
        [XmlElement("isv_hos_no")]
        public string IsvHosNo { get; set; }

        /// <summary>
        /// 服务商用户ID
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
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝订单唯一标识
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单支付状态
        /// </summary>
        [XmlElement("order_pay_status")]
        public string OrderPayStatus { get; set; }

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
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 外部唯一订单ID
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 就诊人id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 就诊人证件ID
        /// </summary>
        [XmlElement("patient_id_card")]
        public string PatientIdCard { get; set; }

        /// <summary>
        /// 就诊人证件类型
        /// </summary>
        [XmlElement("patient_id_type")]
        public string PatientIdType { get; set; }

        /// <summary>
        /// 就诊人手机号码
        /// </summary>
        [XmlElement("patient_moblie")]
        public string PatientMoblie { get; set; }

        /// <summary>
        /// 就诊人名称
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 号源排班日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班ID
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 场景编码，枚举值 管家APP: HEALTH_BUTLER_APP  管家小程序：HEALTH_BUTLER 安诊儿APP: AN_ZHEN_ER_APP 安诊儿小程序 AN_ZHEN_ER 挂号频道小程序 CHANNEL_SEARCH_REGISTER SINGLE_HOS_NFYKDZJ_APP_SCENE  珠江医院（扁鹊单院版APP） SINGLE_HOS_NFYKDZJ_SCENE  珠江医院（扁鹊单院版小程序）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        [XmlElement("shift_type")]
        public string ShiftType { get; set; }

        /// <summary>
        /// 子场景编码
        /// </summary>
        [XmlElement("sub_scene_code")]
        public string SubSceneCode { get; set; }
    }
}
