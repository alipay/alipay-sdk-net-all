using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdDmpcrowdBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcrowdDmpcrowdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 该参数表明自定义人群包信息，包括人群包id，名称，覆盖人群和有效期
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_xlight_crowd")]
        public List<OpenXlightCrowd> Data { get; set; }
    }
}
