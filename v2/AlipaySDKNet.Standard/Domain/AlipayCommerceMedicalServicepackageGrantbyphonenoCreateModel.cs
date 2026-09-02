using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCreateModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 服务生效天数
        /// </summary>
        [XmlElement("effect_days")]
        public long EffectDays { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否开通主订单，不传不开通
        /// </summary>
        [XmlElement("open_main")]
        public bool OpenMain { get; set; }

        /// <summary>
        /// 外部唯一单号
        /// </summary>
        [XmlElement("out_unique_biz_no")]
        public string OutUniqueBizNo { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 服务项限制使用规则
        /// </summary>
        [XmlElement("service_item_restrict_rule_list")]
        public ServiceItemRestrictRule ServiceItemRestrictRuleList { get; set; }

        /// <summary>
        /// 指定可用开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sub_user_info_list")]
        [XmlArrayItem("sub_user_info")]
        public List<SubUserInfo> SubUserInfoList { get; set; }

        /// <summary>
        /// 支付宝用户的唯一ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 指定的用户可用开始时间
        /// </summary>
        [XmlElement("user_start_time")]
        public string UserStartTime { get; set; }
    }
}
