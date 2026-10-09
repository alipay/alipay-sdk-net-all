using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerMembersDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerMembersDeleteModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 域账号（如传入则删除联系人）
        /// </summary>
        [XmlElement("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 登陆支付宝账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 业务小程序id
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
