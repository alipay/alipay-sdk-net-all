using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardAgreementcontentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardAgreementcontentQueryModel : AopObject
    {
        /// <summary>
        /// 售卖订单Id(安心付卡号)
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 购卡用户的openId，out_order_no查询时，user_id和open_id必选一个
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 售卖订单(安心付卡)的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 购卡用户uid，当使用out_order_no查询时，user_id和open_id必选一个
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
