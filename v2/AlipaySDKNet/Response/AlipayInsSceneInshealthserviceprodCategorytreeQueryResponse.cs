using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodCategorytreeQueryResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodCategorytreeQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目树节点列表
        /// </summary>
        [XmlElement("category_tree_list")]
        public ExternalCategoryTreeNode CategoryTreeList { get; set; }
    }
}
