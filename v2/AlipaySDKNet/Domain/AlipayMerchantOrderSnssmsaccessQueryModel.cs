using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSnssmsaccessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSnssmsaccessQueryModel : AopObject
    {
        /// <summary>
        /// 接口提供给服务商调用，相关接口调用时会通知服务商方调用活动编码，会服务商咨询活动配置人员。且活动编码属于动态变化，不能用枚举列举。
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 决策扩展信息
        /// </summary>
        [XmlElement("decision_ext_info")]
        public DecisionExtInfo DecisionExtInfo { get; set; }

        /// <summary>
        /// 人传人用户信息
        /// </summary>
        [XmlElement("user_access_info")]
        public UserAccessInfo UserAccessInfo { get; set; }
    }
}
