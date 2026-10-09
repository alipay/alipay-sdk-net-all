using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVirtualprizeUserGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVirtualprizeUserGetModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 奖品授予时间
        /// </summary>
        [XmlElement("grant_time")]
        public string GrantTime { get; set; }

        /// <summary>
        /// 用户OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部奖品id
        /// </summary>
        [XmlArray("out_prize_ids")]
        [XmlArrayItem("string")]
        public List<string> OutPrizeIds { get; set; }

        /// <summary>
        /// 1：授予；0：取消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
