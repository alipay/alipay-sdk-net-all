using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BianqueConfigItem Data Structure.
    /// </summary>
    [Serializable]
    public class BianqueConfigItem : AopObject
    {
        /// <summary>
        /// 阿福端免订阅消息打开
        /// </summary>
        [XmlElement("afu_no_subscribe_msg_enabled")]
        public HospitalConfigItem AfuNoSubscribeMsgEnabled { get; set; }

        /// <summary>
        /// 检查预约是否接入
        /// </summary>
        [XmlElement("check_appointment_enabled")]
        public HospitalConfigItem CheckAppointmentEnabled { get; set; }

        /// <summary>
        /// 云陪诊服务进阿福
        /// </summary>
        [XmlElement("cloud_consult_afu_enabled")]
        public HospitalConfigItem CloudConsultAfuEnabled { get; set; }

        /// <summary>
        /// 机构来源
        /// </summary>
        [XmlElement("institutional_source")]
        public string InstitutionalSource { get; set; }

        /// <summary>
        /// 在线取号是否接入
        /// </summary>
        [XmlElement("online_register_enabled")]
        public HospitalConfigItem OnlineRegisterEnabled { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("online_sign_in_enabled")]
        [XmlArrayItem("hospital_config_item")]
        public List<HospitalConfigItem> OnlineSignInEnabled { get; set; }

        /// <summary>
        /// 缴费是否接入
        /// </summary>
        [XmlElement("payment_access_enabled")]
        public HospitalConfigItem PaymentAccessEnabled { get; set; }

        /// <summary>
        /// 缴费接入模式
        /// </summary>
        [XmlElement("payment_access_mode")]
        public string PaymentAccessMode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("payment_jump_config")]
        [XmlArrayItem("bianque_jump_chain_config")]
        public List<BianqueJumpChainConfig> PaymentJumpConfig { get; set; }

        /// <summary>
        /// 缴费跳链是否支持医保
        /// </summary>
        [XmlElement("payment_jump_support_medical")]
        public HospitalConfigItem PaymentJumpSupportMedical { get; set; }

        /// <summary>
        /// 缴费是否支持医保
        /// </summary>
        [XmlElement("payment_medical_enabled")]
        public HospitalConfigItem PaymentMedicalEnabled { get; set; }

        /// <summary>
        /// 挂号是否接入
        /// </summary>
        [XmlElement("register_access_enabled")]
        public HospitalConfigItem RegisterAccessEnabled { get; set; }

        /// <summary>
        /// 挂号接入模式
        /// </summary>
        [XmlElement("register_access_mode")]
        public string RegisterAccessMode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_access_enabled")]
        [XmlArrayItem("hospital_config_item")]
        public List<HospitalConfigItem> ReportAccessEnabled { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_access_mode")]
        [XmlArrayItem("hospital_config_item")]
        public List<HospitalConfigItem> ReportAccessMode { get; set; }

        /// <summary>
        /// 是 统一社会信用编码（18位）
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }
    }
}
