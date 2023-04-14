using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemSecurityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品ID列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }
    }
}
