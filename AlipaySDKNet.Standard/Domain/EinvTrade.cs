using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EinvTrade Data Structure.
    /// </summary>
    [Serializable]
    public class EinvTrade : AopObject
    {
        /// <summary>
        /// 账单明细信息，酒店水单信息，行程单信息，餐饮小票信息
        /// </summary>
        [XmlElement("detail_json")]
        public string DetailJson { get; set; }

        /// <summary>
        /// 扩展参数  不同组的k-v通过换行符区分
        /// </summary>
        [XmlElement("extend_map")]
        public string ExtendMap { get; set; }

        /// <summary>
        /// 商家名称（显示名称，非企业名称，餐饮店、酒店、打车平台名称）
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 透传字段，不做处理，用于isv向后续报销税控方传递特殊信息标记
        /// </summary>
        [XmlElement("out_json")]
        public string OutJson { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 支付金额  对应账单中的交易金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付时间  对应账单中的账单日期
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 交易类型来源 需要按照枚举映射  consume 账单  hotel 酒店水单  itinerary 打车行程单  catering 餐饮小票
        /// </summary>
        [XmlElement("souce")]
        public string Souce { get; set; }

        /// <summary>
        /// 交易类型/账单分类
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
