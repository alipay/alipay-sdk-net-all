using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserDetail : AopObject
    {
        /// <summary>
        /// userid列表
        /// </summary>
        [XmlArray("list_open_id")]
        [XmlArrayItem("string")]
        public List<string> ListOpenId { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// userid列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
