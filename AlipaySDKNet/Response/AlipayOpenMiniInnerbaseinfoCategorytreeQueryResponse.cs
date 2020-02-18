using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCategorytreeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCategorytreeQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序一级类目列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("mini_app_first_category_info")]
        public List<MiniAppFirstCategoryInfo> CategoryList { get; set; }
    }
}
