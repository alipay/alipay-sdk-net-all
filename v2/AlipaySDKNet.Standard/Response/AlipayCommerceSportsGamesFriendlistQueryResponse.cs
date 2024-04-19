using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsGamesFriendlistQueryResponse.
    /// </summary>
    public class AlipayCommerceSportsGamesFriendlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 好友信息集合
        /// </summary>
        [XmlArray("friend_list")]
        [XmlArrayItem("friend_v_o")]
        public List<FriendVO> FriendList { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("self_open_id")]
        public string SelfOpenId { get; set; }
    }
}
