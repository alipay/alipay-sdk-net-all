using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountExrateConfigSyncResponse.
    /// </summary>
    public class AlipayAccountExrateConfigSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步到主站的配置的bcode信息
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }
    }
}
