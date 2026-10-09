using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenCloudAppProductQueryResponse.
    /// </summary>
    public class AlipayOpenCloudAppProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 前台产品列表
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("front_product_v_o")]
        public List<FrontProductVO> ProductList { get; set; }
    }
}
