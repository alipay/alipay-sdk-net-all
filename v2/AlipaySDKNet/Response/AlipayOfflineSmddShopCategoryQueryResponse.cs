using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddShopCategoryQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddShopCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目列表
        /// </summary>
        [XmlArray("menu_list")]
        [XmlArrayItem("menu_bean")]
        public List<MenuBean> MenuList { get; set; }
    }
}
