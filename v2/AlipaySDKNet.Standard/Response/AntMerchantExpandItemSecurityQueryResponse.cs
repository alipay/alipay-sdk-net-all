using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandItemSecurityQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemSecurityQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("cm_item_info")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
