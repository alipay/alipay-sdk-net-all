using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherDelayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherDelayModel : AopObject
    {
        /// <summary>
        /// 1、券模板上的过期时间为绝对时间，传不传都使用券模板上的过期时间 2、券模板上的过期时间为相对时间，min（券激活时间+相对时间，入参expired_time）
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId) ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，用户幂等控制。相同voucher_id和out_biz_no被认为是同一次操作
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 待延期的券id ，来自发券接口alipay.marketing.voucher.send
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
