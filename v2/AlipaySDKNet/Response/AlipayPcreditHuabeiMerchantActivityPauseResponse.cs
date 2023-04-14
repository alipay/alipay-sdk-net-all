using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityPauseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityPauseResponse : AopResponse
    {
        /// <summary>
        /// 商户活动ID
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号,用于幂等管理
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
