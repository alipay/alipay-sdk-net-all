using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingGiftQueryResponse.
    /// </summary>
    public class AlipayInsMarketingGiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道规则码
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 赠险产品标志
        /// </summary>
        [XmlElement("gift_prod_code")]
        public string GiftProdCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否开通
        /// </summary>
        [XmlElement("opened")]
        public bool Opened { get; set; }

        /// <summary>
        /// 赠险产品是否开通列表
        /// </summary>
        [XmlArray("right_no_opened_list")]
        [XmlArrayItem("right_no_opened_list")]
        public List<RightNoOpenedList> RightNoOpenedList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
