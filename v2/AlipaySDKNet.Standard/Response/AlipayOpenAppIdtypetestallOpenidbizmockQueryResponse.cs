using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppIdtypetestallOpenidbizmockQueryResponse.
    /// </summary>
    public class AlipayOpenAppIdtypetestallOpenidbizmockQueryResponse : AopResponse
    {
        /// <summary>
        /// idType
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("id_type_list")]
        public string IdTypeList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("list_id_type")]
        public string ListIdType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("list_open_id")]
        public string ListOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("list_user_id")]
        public string ListUserId { get; set; }

        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// idType测试
        /// </summary>
        [XmlElement("user_detail")]
        public IdTypeUserDetail UserDetail { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("user_detail_list")]
        [XmlArrayItem("id_type_user_detail")]
        public List<IdTypeUserDetail> UserDetailList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("zone_type")]
        public string ZoneType { get; set; }
    }
}
