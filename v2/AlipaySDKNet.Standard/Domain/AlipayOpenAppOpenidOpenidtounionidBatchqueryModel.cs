using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidOpenidtounionidBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidOpenidtounionidBatchqueryModel : AopObject
    {
        /// <summary>
        /// 待查询转换的openid列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }
    }
}
