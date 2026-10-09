using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationTransportQueryResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationTransportQueryResponse : AopResponse
    {
        /// <summary>
        /// 创作搬运信息列表
        /// </summary>
        [XmlArray("transport_infos")]
        [XmlArrayItem("transport_info")]
        public List<TransportInfo> TransportInfos { get; set; }
    }
}
