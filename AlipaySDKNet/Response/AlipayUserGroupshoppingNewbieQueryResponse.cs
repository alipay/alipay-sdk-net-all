using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGroupshoppingNewbieQueryResponse.
    /// </summary>
    public class AlipayUserGroupshoppingNewbieQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否可参与一元团
        /// </summary>
        [XmlElement("access")]
        public bool Access { get; set; }

        /// <summary>
        /// 输出的文案信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 当前用户状态，未被邀请，未绑定手机号等
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 返回传入用户下的user_id列表，查询整个列表中的user_id是否有一元拼的记录。
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
