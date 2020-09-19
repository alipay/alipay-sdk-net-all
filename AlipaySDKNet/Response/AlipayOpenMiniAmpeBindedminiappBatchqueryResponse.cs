using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeBindedminiappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeBindedminiappBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定的小程序信息列表
        /// </summary>
        [XmlArray("binded_mini_app_list")]
        [XmlArrayItem("binded_mini_app_info")]
        public List<BindedMiniAppInfo> BindedMiniAppList { get; set; }

        /// <summary>
        /// 已绑定小程序的总个数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
