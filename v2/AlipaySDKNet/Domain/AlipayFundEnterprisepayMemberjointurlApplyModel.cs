using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayMemberjointurlApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayMemberjointurlApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 必填，如有不填协议号的需求，请联系支付宝同学
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 二维码链接的过期时间，以天为单位，传入的必须是正整数。默认最长过期时间为365天，如果有需要更改最长过期时间的，联系支付宝分配； 过期时间从当天的23:59:59分开始算。如在1号任意时间申请二维码链接且过期时间1天，那么到期时间为2号23:59:59
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
