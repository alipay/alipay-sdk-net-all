using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneChannelsaleVoucherCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneChannelsaleVoucherCancelModel : AopObject
    {
        /// <summary>
        /// 渠道商户ID，蚂蚁保分配
        /// </summary>
        [XmlElement("channel_merchant_id")]
        public string ChannelMerchantId { get; set; }

        /// <summary>
        /// 失效原因
        /// </summary>
        [XmlElement("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 合作商ID，由蚂蚁保分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 凭证编码，发放凭证接口返回
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
