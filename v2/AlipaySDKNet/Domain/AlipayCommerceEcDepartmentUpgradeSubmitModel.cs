using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDepartmentUpgradeSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDepartmentUpgradeSubmitModel : AopObject
    {
        /// <summary>
        /// 待升级的部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 部门升级为子企业后的企业名称
        /// </summary>
        [XmlElement("sub_enterprise_name")]
        public string SubEnterpriseName { get; set; }

        /// <summary>
        /// 子企业企业支付宝身份标识，对应identity_type进行传参： 1. 手机号或者邮箱（当身份类型传ALIPAY_LOGON_ID时） 2. 支付宝会员id（当身份类型传ALIPAY_USER_ID时）
        /// </summary>
        [XmlElement("sub_identity")]
        public string SubIdentity { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("sub_identity_open_id")]
        public string SubIdentityOpenId { get; set; }

        /// <summary>
        /// 子企业企业支付宝身份类型，支持支付宝会员id和登录账号
        /// </summary>
        [XmlElement("sub_identity_type")]
        public string SubIdentityType { get; set; }
    }
}
