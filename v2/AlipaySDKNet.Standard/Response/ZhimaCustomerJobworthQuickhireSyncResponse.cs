using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthQuickhireSyncResponse.
    /// </summary>
    public class ZhimaCustomerJobworthQuickhireSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果，true代表同步成功，false代表同步失败，如果为false，商户需要重试
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
