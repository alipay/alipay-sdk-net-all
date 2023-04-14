using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerMembersAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerMembersAddModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 域账号（不为空时会添加联系人）
        /// </summary>
        [XmlElement("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝登陆账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 业务appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 成员类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
