using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceEnterpriseuserAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceEnterpriseuserAuthModel : AopObject
    {
        /// <summary>
        /// 根据登录渠道不同，填写不同的账号
        /// </summary>
        [XmlElement("auth_account")]
        public string AuthAccount { get; set; }

        /// <summary>
        /// 登录渠道，如手机、邮箱、用户ID等
        /// </summary>
        [XmlElement("auth_channel")]
        public string AuthChannel { get; set; }

        /// <summary>
        /// 星云的租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
