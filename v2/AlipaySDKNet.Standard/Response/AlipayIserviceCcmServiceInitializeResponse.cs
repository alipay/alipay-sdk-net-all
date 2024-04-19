using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmServiceInitializeResponse.
    /// </summary>
    public class AlipayIserviceCcmServiceInitializeResponse : AopResponse
    {
        /// <summary>
        /// spi在ccm中的唯一标识，与biz_code一一对应
        /// </summary>
        [XmlArray("spi_ids")]
        [XmlArrayItem("spi_result")]
        public List<SpiResult> SpiIds { get; set; }
    }
}
