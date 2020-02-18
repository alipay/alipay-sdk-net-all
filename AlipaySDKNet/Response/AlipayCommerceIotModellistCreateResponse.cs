using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotModellistCreateResponse.
    /// </summary>
    public class AlipayCommerceIotModellistCreateResponse : AopResponse
    {
        /// <summary>
        /// 重复的型号id列表，当所请求创建的型号已经存在时，则将已存在的型号id列表通过该字段返回
        /// </summary>
        [XmlArray("duplicated_model_ids")]
        [XmlArrayItem("string")]
        public List<string> DuplicatedModelIds { get; set; }
    }
}
