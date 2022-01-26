using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsCategoryQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiGoodsCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目详情信息
        /// </summary>
        [XmlArray("categorys")]
        [XmlArrayItem("goods_category_result")]
        public List<GoodsCategoryResult> Categorys { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
