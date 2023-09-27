using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotgmsTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotgmsTokenCreateModel : AopObject
    {
        /// <summary>
        /// 需要查询功能列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("string")]
        public List<string> Functions { get; set; }

        /// <summary>
        /// 图片记录对应的用户openId，蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 要查询的订单列表
        /// </summary>
        [XmlArray("query_list")]
        [XmlArrayItem("query_param")]
        public List<QueryParam> QueryList { get; set; }

        /// <summary>
        /// 行业场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 图片记录对应的用户uid，蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
