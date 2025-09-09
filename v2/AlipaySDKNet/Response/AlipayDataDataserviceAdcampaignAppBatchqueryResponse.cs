using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignAppBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignAppBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("alipay_app_res")]
        public List<AlipayAppRes> Data { get; set; }
    }
}
