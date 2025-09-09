using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransRenderPayResponse.
    /// </summary>
    public class AlipayFundTransRenderPayResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转的编码
        /// </summary>
        [XmlElement("initialize_code")]
        public string InitializeCode { get; set; }

        /// <summary>
        /// 跳转的编码类型
        /// </summary>
        [XmlElement("initialize_code_type")]
        public string InitializeCodeType { get; set; }

        /// <summary>
        /// 指定的资金订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
