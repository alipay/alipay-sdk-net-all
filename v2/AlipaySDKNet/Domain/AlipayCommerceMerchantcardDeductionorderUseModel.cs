using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardDeductionorderUseModel : AopObject
    {
        /// <summary>
        /// 幂等号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 售卖订单id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 注意：先享次卡目前只支持同时核销1次
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家发起核销需要服务商回传外部交易订单号，商户开启了用户核销免授权确认，参数必传。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 推荐填入，一般填写核销原因
        /// </summary>
        [XmlElement("use_desc")]
        public string UseDesc { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
