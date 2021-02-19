using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUserActivityvoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUserActivityvoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券状态： 可使用(ENABLED)，已核销(即完全使用，USED)，已过期(EXPIRED)
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
