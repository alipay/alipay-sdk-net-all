using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsTagQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiGoodsTagQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("goods_tag_result")]
        public List<GoodsTagResult> Tags { get; set; }
    }
}
