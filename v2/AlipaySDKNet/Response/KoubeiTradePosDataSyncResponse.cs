using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradePosDataSyncResponse.
    /// </summary>
    public class KoubeiTradePosDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
