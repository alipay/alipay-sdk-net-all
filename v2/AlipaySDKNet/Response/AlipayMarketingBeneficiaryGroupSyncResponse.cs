using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBeneficiaryGroupSyncResponse.
    /// </summary>
    public class AlipayMarketingBeneficiaryGroupSyncResponse : AopResponse
    {
        /// <summary>
        /// 消费券平台返回业务号
        /// </summary>
        [XmlElement("sync_biz_no")]
        public string SyncBizNo { get; set; }
    }
}
