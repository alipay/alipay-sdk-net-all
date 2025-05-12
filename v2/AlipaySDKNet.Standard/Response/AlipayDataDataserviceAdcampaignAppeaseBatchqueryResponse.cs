using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignAppeaseBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignAppeaseBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序页面信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("alipay_app_page_res")]
        public List<AlipayAppPageRes> Data { get; set; }
    }
}
