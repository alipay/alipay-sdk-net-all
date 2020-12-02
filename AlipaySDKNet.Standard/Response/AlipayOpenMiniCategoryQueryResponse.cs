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
        /// 小程序新类目列表。小程序新类目列表，为三级类目。创建、修改、提审传入mini_category_ids，资质相关请参考https://opendocs.alipay.com/mini/operation/material 
        /// </summary>
        [XmlArray("mini_category_list")]
        [XmlArrayItem("mini_app_category")]
        public List<MiniAppCategory> MiniCategoryList { get; set; }
    }
}
