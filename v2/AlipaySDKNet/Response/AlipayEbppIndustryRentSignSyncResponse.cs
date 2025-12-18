using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentSignSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryRentSignSyncResponse : AopResponse
    {
        /// <summary>
        /// 签约状态同步成功
        /// </summary>
        [XmlElement("sync_status")]
        public bool SyncStatus { get; set; }
    }
}
