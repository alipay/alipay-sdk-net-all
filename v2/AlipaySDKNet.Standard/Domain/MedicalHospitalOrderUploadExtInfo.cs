using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHospitalOrderUploadExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalOrderUploadExtInfo : AopObject
    {
        /// <summary>
        /// 叫号进度页面跳转链接，支付宝小程序链接
        /// </summary>
        [XmlElement("call_num_url")]
        public string CallNumUrl { get; set; }

        /// <summary>
        /// 检查项目名称
        /// </summary>
        [XmlElement("check_item")]
        public string CheckItem { get; set; }

        /// <summary>
        /// 检查室位置
        /// </summary>
        [XmlElement("check_loc")]
        public string CheckLoc { get; set; }

        /// <summary>
        /// 检查室编号
        /// </summary>
        [XmlElement("check_num")]
        public string CheckNum { get; set; }

        /// <summary>
        /// 检查注意事项
        /// </summary>
        [XmlElement("check_precautions")]
        public string CheckPrecautions { get; set; }

        /// <summary>
        /// 实际检查时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 当前叫号
        /// </summary>
        [XmlElement("current_num")]
        public string CurrentNum { get; set; }

        /// <summary>
        /// 就诊科室/检查科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 科室位置
        /// </summary>
        [XmlElement("dept_loc")]
        public string DeptLoc { get; set; }

        /// <summary>
        /// 诊室编号
        /// </summary>
        [XmlElement("dept_num")]
        public string DeptNum { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor")]
        public string Doctor { get; set; }

        /// <summary>
        /// 医生头像url
        /// </summary>
        [XmlElement("doctor_avatar")]
        public string DoctorAvatar { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生职级
        /// </summary>
        [XmlElement("doctor_rank")]
        public string DoctorRank { get; set; }

        /// <summary>
        /// 预计等待时间（分）
        /// </summary>
        [XmlElement("expected_waiting_time")]
        public long ExpectedWaitingTime { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 医院ID类型 医保局- 1 卫健委- 2
        /// </summary>
        [XmlElement("hospital_id_type")]
        public string HospitalIdType { get; set; }

        /// <summary>
        /// 医院登记号( 卫健登记号或国标编码)
        /// </summary>
        [XmlElement("hospital_register_id")]
        public string HospitalRegisterId { get; set; }

        /// <summary>
        /// 是否本人挂号：是/否/未知
        /// </summary>
        [XmlElement("is_done_by_self")]
        public string IsDoneBySelf { get; set; }

        /// <summary>
        /// 就诊/检查序号
        /// </summary>
        [XmlElement("medical_num")]
        public string MedicalNum { get; set; }

        /// <summary>
        /// 就诊单id
        /// </summary>
        [XmlElement("medical_order_id")]
        public string MedicalOrderId { get; set; }

        /// <summary>
        /// 订单链接，支付宝小程序链接
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 医院小程序链接：HOSPITAL_TINYAPP_LINK 区域平台小程序链接：REGIONAL_PLATFORM_TINYAPP_LINK
        /// </summary>
        [XmlElement("merchant_order_link_type")]
        public string MerchantOrderLinkType { get; set; }

        /// <summary>
        /// 导航地址页面跳转链接，支付宝小程序链接
        /// </summary>
        [XmlElement("navigation")]
        public string Navigation { get; set; }

        /// <summary>
        /// 就诊人
        /// </summary>
        [XmlElement("patient")]
        public string Patient { get; set; }

        /// <summary>
        /// 查看报告链接，支付宝小程序链接
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        [XmlElement("scheduled_time")]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 温馨提示，文本类型，最长200个中文字
        /// </summary>
        [XmlElement("summary_tip")]
        public string SummaryTip { get; set; }

        /// <summary>
        /// 取药地址
        /// </summary>
        [XmlElement("take_medicine_loc")]
        public string TakeMedicineLoc { get; set; }

        /// <summary>
        /// 取药导航链接，支付宝小程序链接
        /// </summary>
        [XmlElement("take_medicine_url")]
        public string TakeMedicineUrl { get; set; }

        /// <summary>
        /// 取号密码页面跳转链接，支付宝小程序链接
        /// </summary>
        [XmlElement("take_num_password")]
        public string TakeNumPassword { get; set; }

        /// <summary>
        /// 取号入口页面跳转链接，支付宝小程序链接
        /// </summary>
        [XmlElement("take_num_url")]
        public string TakeNumUrl { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 证件类型，01代表身份证，当前只支持身份证
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }

        /// <summary>
        /// 前方等待人数
        /// </summary>
        [XmlElement("waiting_num")]
        public long WaitingNum { get; set; }
    }
}
