using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoritegiftQueryModel : AopObject
    {
        /// <summary>
        /// 收藏有礼查询每个小程序相关信息的列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity_query_info")]
        public List<ActivityQueryInfo> ActivityList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
