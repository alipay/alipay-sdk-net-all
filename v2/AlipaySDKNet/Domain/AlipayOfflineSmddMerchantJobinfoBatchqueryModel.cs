using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddMerchantJobinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddMerchantJobinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("merchant_id_list")]
        [XmlArrayItem("string")]
        public List<string> MerchantIdList { get; set; }
    }
}
