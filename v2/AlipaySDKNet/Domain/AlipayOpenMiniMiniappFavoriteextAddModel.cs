using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteextAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoriteextAddModel : AopObject
    {
        /// <summary>
        /// 小程序收藏业务类型，需要申请分配
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// json格式，扩展信息，key是principleId，value是json串
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 收藏实体principleIds的来源，需要申请分配
        /// </summary>
        [XmlElement("principal_biz_type")]
        public string PrincipalBizType { get; set; }

        /// <summary>
        /// 业务id，比如口碑店铺id
        /// </summary>
        [XmlArray("principal_ids")]
        [XmlArrayItem("string")]
        public List<string> PrincipalIds { get; set; }

        /// <summary>
        /// 收藏实体的枚举类型，ITEM：商品，SHOP：店铺，SERVICE：服务
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
