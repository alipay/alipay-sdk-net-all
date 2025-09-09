using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterinviteCreateResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseRegisterinviteCreateResponse : AopResponse
    {
        /// <summary>
        /// 注册链接失效时间，有效期30天
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// PC端企业注册链接
        /// </summary>
        [XmlElement("pc_invite_url")]
        public string PcInviteUrl { get; set; }
    }
}
