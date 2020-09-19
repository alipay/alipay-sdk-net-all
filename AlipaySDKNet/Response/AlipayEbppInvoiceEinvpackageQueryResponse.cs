using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEinvpackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票包明细数据
        /// </summary>
        [XmlArray("package_item_info_list")]
        [XmlArrayItem("package_item_open_info")]
        public List<PackageItemOpenInfo> PackageItemInfoList { get; set; }
    }
}
