using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingGiftSendResponse.
    /// </summary>
    public class AlipayInsMarketingGiftSendResponse : AopResponse
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
        /// 赠险产品保额发放列表
        /// </summary>
        [XmlArray("right_no_send_list")]
        [XmlArrayItem("right_no_send_list")]
        public List<RightNoSendList> RightNoSendList { get; set; }

        /// <summary>
        /// 本次发放总保额
        /// </summary>
        [XmlElement("send_sum_insured")]
        public string SendSumInsured { get; set; }

        /// <summary>
        /// 业务成功失败标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
