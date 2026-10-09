using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePolicyLinksAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePolicyLinksAuthModel : AopObject
    {
        /// <summary>
        /// 登录用户id
        /// </summary>
        [XmlElement("login_user_id")]
        public string LoginUserId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// session过期时间
        /// </summary>
        [XmlElement("out_session_expiration")]
        public string OutSessionExpiration { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 指定保单号，选填
        /// </summary>
        [XmlArray("policy_nos")]
        [XmlArrayItem("string")]
        public List<string> PolicyNos { get; set; }

        /// <summary>
        /// 客户端渠道 ios / android / pc / wx_applet(微信小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
