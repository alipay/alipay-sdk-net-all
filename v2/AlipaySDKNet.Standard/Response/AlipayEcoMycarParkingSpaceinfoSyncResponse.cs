using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingSpaceinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingSpaceinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
