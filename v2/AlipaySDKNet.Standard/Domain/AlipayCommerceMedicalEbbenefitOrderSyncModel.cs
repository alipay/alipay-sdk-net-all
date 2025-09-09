using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEbbenefitOrderSyncModel : AopObject
    {
        /// <summary>
        /// 采购企业id （蚂蚁提供）
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 医生头像地址
        /// </summary>
        [XmlElement("doctor_avatar_url")]
        public string DoctorAvatarUrl { get; set; }

        /// <summary>
        /// 医生所在科室
        /// </summary>
        [XmlElement("doctor_department")]
        public string DoctorDepartment { get; set; }

        /// <summary>
        /// 医生教学职称
        /// </summary>
        [XmlElement("doctor_education_title")]
        public string DoctorEducationTitle { get; set; }

        /// <summary>
        /// 医生所在医院
        /// </summary>
        [XmlElement("doctor_hospital")]
        public string DoctorHospital { get; set; }

        /// <summary>
        /// 医生所在医院级别
        /// </summary>
        [XmlElement("doctor_hospital_level")]
        public string DoctorHospitalLevel { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [XmlElement("eb_user_id")]
        public string EbUserId { get; set; }

        /// <summary>
        /// 服务类型  图文问诊:IMAGE_INQUIRY 电话问诊:PHONE_INQUIRY 视频问诊:VIDEO_INQUIRY 快速图文:QUICK_IMAGE_INQUIRY 快速电话:QUICK_PHONE_INQUIRY 快速视频:QUICK_VIDEO_INQUIRY 互联网门诊（电话）: INTERNET_CLINIC_PHONE 互联网门诊（视频）: INTERNET_CLINIC_VIDEO 门诊安排：CLINIC_ARRANGEMENT 住院安排：HOSPITALIZATION_ARRANGEMENTS
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 家庭成员年龄
        /// </summary>
        [XmlElement("member_age")]
        public string MemberAge { get; set; }

        /// <summary>
        /// 家庭成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 三方订单详情链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 三方im链接
        /// </summary>
        [XmlElement("order_im_url")]
        public string OrderImUrl { get; set; }

        /// <summary>
        /// 专家问诊：（待接诊、问诊中、已完成、已取消）体检解读：（待接诊、问诊中、已取消、已完成）家庭医生：（待接诊、问诊中、已取消、已完成）就医协助：（问诊中、已完成） 顾问服务：（进行中、已完成）
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型  专家问诊、体检解读、就医协助、家庭医生、顾问服务
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_doctor_id")]
        public string OutDoctorId { get; set; }

        /// <summary>
        /// 外部家庭成员id
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部父单号
        /// </summary>
        [XmlElement("out_parent_order_id")]
        public string OutParentOrderId { get; set; }

        /// <summary>
        /// 外部子用户ID
        /// </summary>
        [XmlElement("out_sub_user_id")]
        public string OutSubUserId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 产品id（蚂蚁提供）
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 服务提供企业id（蚂蚁提供）
        /// </summary>
        [XmlElement("provide_company_id")]
        public string ProvideCompanyId { get; set; }

        /// <summary>
        /// 是否自费，1自费，0非自费
        /// </summary>
        [XmlElement("self_funded")]
        public string SelfFunded { get; set; }

        /// <summary>
        /// 订单创建 CREATE_ORDER, 状态同步 STATUS_CHANGE
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
