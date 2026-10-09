using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderbillApplistBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderbillApplistBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序列表详情
        /// </summary>
        [XmlArray("app_list")]
        [XmlArrayItem("app_base_info")]
        public List<AppBaseInfo> AppList { get; set; }

        /// <summary>
        /// 总条数，在业务账单有出账记录的小程序总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
