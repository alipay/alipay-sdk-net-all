using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingGoodsDataVerifyResponse.
    /// </summary>
    public class AlipayMarketingGoodsDataVerifyResponse : AopResponse
    {
        /// <summary>
        /// 流水id写操作接口返回
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 返回第三方业务信息
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
