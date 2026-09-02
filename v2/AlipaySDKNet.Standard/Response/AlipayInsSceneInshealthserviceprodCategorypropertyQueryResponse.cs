using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodCategorypropertyQueryResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodCategorypropertyQueryResponse : AopResponse
    {
        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("properties")]
        [XmlArrayItem("external_cate_property")]
        public List<ExternalCateProperty> Properties { get; set; }
    }
}
