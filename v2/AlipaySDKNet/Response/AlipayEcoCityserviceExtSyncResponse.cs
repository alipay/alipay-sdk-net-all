using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceExtSyncResponse.
    /// </summary>
    public class AlipayEcoCityserviceExtSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("result")]
        public SyncDataResult Result { get; set; }
    }
}
