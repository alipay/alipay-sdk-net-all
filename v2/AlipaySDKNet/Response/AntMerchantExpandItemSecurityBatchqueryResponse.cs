using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandItemSecurityBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandItemSecurityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("cm_item_info")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
