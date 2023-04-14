using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniModelQueryResponse.
    /// </summary>
    public class AlipayOpenMiniModelQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁域小程序核心模型查询接口返回对象，model_type：查询模型类型，records：记录列表
        /// </summary>
        [XmlArray("model_infos")]
        [XmlArrayItem("mini_app_model_query_response")]
        public List<MiniAppModelQueryResponse> ModelInfos { get; set; }
    }
}
