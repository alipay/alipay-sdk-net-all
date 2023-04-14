using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeExpressQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeExpressQueryResponse : AopResponse
    {
        /// <summary>
        /// 包裹状态分类后的统计结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("ampe_express_query_response")]
        public List<AmpeExpressQueryResponse> Data { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 跳转链接，通过AMPE打开
        /// </summary>
        [XmlElement("merchant_detail_url")]
        public string MerchantDetailUrl { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
