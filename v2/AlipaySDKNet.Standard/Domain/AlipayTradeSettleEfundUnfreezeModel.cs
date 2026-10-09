using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleEfundUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleEfundUnfreezeModel : AopObject
    {
        /// <summary>
        /// 解冻金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 解冻资金备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部请求号，用于幂等控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 卖家openId
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 卖家userId
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 资金解冻业务类型
        /// </summary>
        [XmlElement("settle_biz_type")]
        public string SettleBizType { get; set; }
    }
}
