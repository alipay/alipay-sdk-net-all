using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdThemecrowdBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcrowdThemecrowdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回人群包信息，包括id，名称和覆盖人群数量
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_xlight_crowd")]
        public List<OpenXlightCrowd> Data { get; set; }
    }
}
