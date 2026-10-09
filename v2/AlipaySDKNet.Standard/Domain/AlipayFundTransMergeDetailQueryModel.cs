using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransMergeDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransMergeDetailQueryModel : AopObject
    {
        /// <summary>
        /// 业务的场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝返回的合并单据主单号
        /// </summary>
        [XmlElement("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
