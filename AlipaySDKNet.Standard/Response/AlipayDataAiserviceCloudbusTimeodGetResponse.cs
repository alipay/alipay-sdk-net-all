using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetResponse : AopResponse
    {
        /// <summary>
        /// od分时结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("cloudbus_time_od_item")]
        public List<CloudbusTimeOdItem> Result { get; set; }
    }
}
