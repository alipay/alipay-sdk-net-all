using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("mini_app_category")]
        public List<MiniAppCategory> CategoryList { get; set; }

        /// <summary>
        /// 小程序新类目列表
        /// </summary>
        [XmlArray("mini_category_list")]
        [XmlArrayItem("mini_app_category")]
        public List<MiniAppCategory> MiniCategoryList { get; set; }
    }
}
