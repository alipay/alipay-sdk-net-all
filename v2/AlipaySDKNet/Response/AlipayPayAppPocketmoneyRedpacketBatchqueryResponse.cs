using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyRedpacketBatchqueryResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyRedpacketBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 红包详情list
        /// </summary>
        [XmlArray("red_pocket_list")]
        [XmlArrayItem("red_pocket_info")]
        public List<RedPocketInfo> RedPocketList { get; set; }
    }
}
