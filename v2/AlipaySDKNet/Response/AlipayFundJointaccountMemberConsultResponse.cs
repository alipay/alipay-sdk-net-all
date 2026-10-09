using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountMemberConsultResponse.
    /// </summary>
    public class AlipayFundJointaccountMemberConsultResponse : AopResponse
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 员工列表
        /// </summary>
        [XmlArray("member_list")]
        [XmlArrayItem("member_status_resp_d_t_o")]
        public List<MemberStatusRespDTO> MemberList { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
