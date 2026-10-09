using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingInscouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingInscouponQueryModel : AopObject
    {
        /// <summary>
        /// 绑定券id，可选，如果传了券id，则只查该券对应的权益
        /// </summary>
        [XmlElement("bind_voucher_id")]
        public string BindVoucherId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coupon_type")]
        [XmlArrayItem("string")]
        public List<string> CouponType { get; set; }

        /// <summary>
        /// 开放平台用户的唯一标识符
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部供应商请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
