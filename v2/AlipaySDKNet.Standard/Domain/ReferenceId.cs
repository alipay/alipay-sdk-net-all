using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReferenceId Data Structure.
    /// </summary>
    [Serializable]
    public class ReferenceId : AopObject
    {
        /// <summary>
        /// 关联ID，外部业务平台会员ID
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId_ { get; set; }

        /// <summary>
        /// 关联ID类型，关联ID类型；ALI_ID 阿里巴巴ID；ICBU_ACCT_ID ICBU ID；IP_ID 网商会员ID；IP_ROLE_ID 网商会员角色ID；ALIPAY_ID 支付宝会员ID；ALIPAY_LOGON_ID 支付宝会员登陆外标；WF_ID worldfirst会员ID
        /// </summary>
        [XmlElement("reference_id_type")]
        public string ReferenceIdType { get; set; }
    }
}
