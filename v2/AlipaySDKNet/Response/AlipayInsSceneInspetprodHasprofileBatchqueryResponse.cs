using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInspetprodHasprofileBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneInspetprodHasprofileBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 示例List<QueryProfileDTO>
        /// </summary>
        [XmlArray("model_list")]
        [XmlArrayItem("query_profile_d_t_o")]
        public List<QueryProfileDTO> ModelList { get; set; }
    }
}
