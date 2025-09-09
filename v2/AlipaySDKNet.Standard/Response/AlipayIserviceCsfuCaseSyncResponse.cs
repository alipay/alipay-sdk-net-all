using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCsfuCaseSyncResponse.
    /// </summary>
    public class AlipayIserviceCsfuCaseSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步案件后返回的主键id
        /// </summary>
        [XmlElement("data_id")]
        public long DataId { get; set; }
    }
}
