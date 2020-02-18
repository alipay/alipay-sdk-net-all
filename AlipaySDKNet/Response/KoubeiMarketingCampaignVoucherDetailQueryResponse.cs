using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignVoucherDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignVoucherDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 券状态列表如下：  VALID：可用；WRITED_OFF：已核销；EXPIRED：已过期；CLOSED：已关闭；WAIT_APPLY：已冻结；DELETED：已删除；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券详情对象
        /// </summary>
        [XmlElement("voucher")]
        public Voucher Voucher { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
