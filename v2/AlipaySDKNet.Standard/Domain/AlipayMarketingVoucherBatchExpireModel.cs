using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherBatchExpireModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherBatchExpireModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，用户幂等控制。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("open_batch_expire_voucher")]
        public List<OpenBatchExpireVoucher> Vouchers { get; set; }
    }
}
