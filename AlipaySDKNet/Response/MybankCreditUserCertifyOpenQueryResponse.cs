using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditUserCertifyOpenQueryResponse.
    /// </summary>
    public class MybankCreditUserCertifyOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证错误原因，扩展字段，默认不返回
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 认证的主体信息，一般的认证场景返回为空
        /// </summary>
        [XmlElement("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空
        /// </summary>
        [XmlElement("material_info")]
        public string MaterialInfo { get; set; }

        /// <summary>
        /// 是否通过，通过为T，不通过为F
        /// </summary>
        [XmlElement("passed")]
        public string Passed { get; set; }
    }
}
