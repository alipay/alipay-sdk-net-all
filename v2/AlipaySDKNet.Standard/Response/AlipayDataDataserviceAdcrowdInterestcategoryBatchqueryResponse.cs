using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcrowdInterestcategoryBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcrowdInterestcategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 行为兴趣人群类目数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_xlight_crowd_category")]
        public List<OpenXlightCrowdCategory> Data { get; set; }
    }
}
