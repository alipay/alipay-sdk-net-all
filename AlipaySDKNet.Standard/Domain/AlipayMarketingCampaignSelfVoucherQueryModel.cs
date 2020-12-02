using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignSelfVoucherQueryModel : AopObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
