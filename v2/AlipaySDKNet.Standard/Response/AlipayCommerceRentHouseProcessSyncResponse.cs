using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentHouseProcessSyncResponse.
    /// </summary>
    public class AlipayCommerceRentHouseProcessSyncResponse : AopResponse
    {
        /// <summary>
        /// 过程记录ID，全局唯一
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
