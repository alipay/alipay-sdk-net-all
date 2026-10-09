using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAddressQueryResponse.
    /// </summary>
    public class AntMerchantExpandAddressQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家地址库基本信息集合的list,会有多个商家地址基础信息返回
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("open_query_poim_base_response")]
        public List<OpenQueryPoimBaseResponse> Data { get; set; }
    }
}
