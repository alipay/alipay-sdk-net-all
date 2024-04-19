using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonPremissionAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonPremissionAuthModel : AopObject
    {
        /// <summary>
        /// 订购组件token
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 投保人信息
        /// </summary>
        [XmlElement("holder")]
        public InsOpenUserDTO Holder { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlArray("insureds")]
        [XmlArrayItem("ins_open_user_d_t_o")]
        public List<InsOpenUserDTO> Insureds { get; set; }

        /// <summary>
        /// 外部登录用户id
        /// </summary>
        [XmlElement("login_user_id")]
        public string LoginUserId { get; set; }

        /// <summary>
        /// 外部sessionid
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
