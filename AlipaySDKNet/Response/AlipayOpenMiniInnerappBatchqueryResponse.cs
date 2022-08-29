using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序基础信息列表
        /// </summary>
        [XmlArray("mini_app_base_info_response_list")]
        [XmlArrayItem("mini_app_base_info_response")]
        public List<MiniAppBaseInfoResponse> MiniAppBaseInfoResponseList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
