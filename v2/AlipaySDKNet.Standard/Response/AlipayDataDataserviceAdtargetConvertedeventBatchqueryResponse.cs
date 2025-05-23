using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdtargetConvertedeventBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdtargetConvertedeventBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 可选择的转化事件列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_xlight_converted_event")]
        public List<OpenXlightConvertedEvent> Data { get; set; }
    }
}
