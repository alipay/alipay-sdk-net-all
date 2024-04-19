using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 活动类型，传空默认查所有
        /// </summary>
        [XmlArray("product_ids")]
        [XmlArrayItem("string")]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 查询对应状态活动，默认所有状态活动类型
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
