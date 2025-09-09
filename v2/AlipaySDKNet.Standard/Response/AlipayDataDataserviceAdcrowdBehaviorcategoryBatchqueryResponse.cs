using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdBehaviorcategoryBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcrowdBehaviorcategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 该参数表示行为兴趣人群类目，包含人群包id，名称，覆盖人群
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_xlight_crowd_category")]
        public List<OpenXlightCrowdCategory> Data { get; set; }
    }
}
