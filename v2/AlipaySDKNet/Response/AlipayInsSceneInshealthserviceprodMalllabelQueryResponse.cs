using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMalllabelQueryResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodMalllabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品标签列表
        /// </summary>
        [XmlArray("item_label_list")]
        [XmlArrayItem("external_item_label")]
        public List<ExternalItemLabel> ItemLabelList { get; set; }
    }
}
