using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterRuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterRuleQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 挂号频道:CHANNEL_SEARCH_REGISTER 安诊儿:AN_ZHEN_ER_REGISTER 健康管家:HEALTH_BUTLER_REGISTER
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("isv_hos_dept_no")]
        public string IsvHosDeptNo { get; set; }

        /// <summary>
        /// 服务商医院唯一编码
        /// </summary>
        [XmlElement("isv_hos_no")]
        public string IsvHosNo { get; set; }

        /// <summary>
        /// 服务商用户id
        /// </summary>
        [XmlElement("isv_user_id")]
        public string IsvUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 就诊人信息
        /// </summary>
        [XmlElement("patient_prop")]
        public string PatientProp { get; set; }

        /// <summary>
        /// 平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("rule_ext_info")]
        public string RuleExtInfo { get; set; }

        /// <summary>
        /// 场景编码，枚举值 管家APP: HEALTH_BUTLER_APP 管家小程序：HEALTH_BUTLER 安诊儿APP: AN_ZHEN_ER_APP 安诊儿小程序 AN_ZHEN_ER 挂号频道小程序 CHANNEL_SEARCH_REGISTER SINGLE_HOS_NFYKDZJ_APP_SCENE 珠江医院（扁鹊单院版APP） SINGLE_HOS_NFYKDZJ_SCENE 珠江医院（扁鹊单院版小程序）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
