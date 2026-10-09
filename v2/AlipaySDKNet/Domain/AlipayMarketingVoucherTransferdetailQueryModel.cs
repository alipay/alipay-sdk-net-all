using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTransferdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherTransferdetailQueryModel : AopObject
    {
        /// <summary>
        /// 资产类型过滤, 默认全部返回
        /// </summary>
        [XmlArray("asset_types")]
        [XmlArrayItem("string")]
        public List<string> AssetTypes { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId) ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户ID ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
