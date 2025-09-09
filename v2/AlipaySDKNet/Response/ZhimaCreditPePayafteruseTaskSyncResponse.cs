using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPePayafteruseTaskSyncResponse.
    /// </summary>
    public class ZhimaCreditPePayafteruseTaskSyncResponse : AopResponse
    {
        /// <summary>
        /// 更新是否被幂等处理
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }
    }
}
