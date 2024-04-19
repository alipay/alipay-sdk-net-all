using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryHireApplySyncResponse.
    /// </summary>
    public class AlipayEbppIndustryHireApplySyncResponse : AopResponse
    {
        /// <summary>
        /// 应聘状态同步结果：成功=true，失败=false
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
