using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubUserInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_item_restrict_rule_list")]
        [XmlArrayItem("service_item_restrict_rule")]
        public List<ServiceItemRestrictRule> ServiceItemRestrictRuleList { get; set; }

        /// <summary>
        /// 子订单开始时间
        /// </summary>
        [XmlElement("sub_start_time")]
        public string SubStartTime { get; set; }

        /// <summary>
        /// 子使用人证件号
        /// </summary>
        [XmlElement("sub_user_cert_no")]
        public string SubUserCertNo { get; set; }

        /// <summary>
        /// 子使用人证件类型
        /// </summary>
        [XmlElement("sub_user_cert_type")]
        public string SubUserCertType { get; set; }

        /// <summary>
        /// 子使用人服务包订单生效天数
        /// </summary>
        [XmlElement("sub_user_effect_days")]
        public string SubUserEffectDays { get; set; }

        /// <summary>
        /// 子使用人姓名
        /// </summary>
        [XmlElement("sub_user_name")]
        public string SubUserName { get; set; }

        /// <summary>
        /// 子使用人手机号
        /// </summary>
        [XmlElement("sub_user_phone_no")]
        public string SubUserPhoneNo { get; set; }

        /// <summary>
        /// 子使用人服务包订单可用开始时间
        /// </summary>
        [XmlElement("sub_user_start_time")]
        public string SubUserStartTime { get; set; }
    }
}
