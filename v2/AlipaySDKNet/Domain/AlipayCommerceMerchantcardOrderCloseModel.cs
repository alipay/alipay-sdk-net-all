using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOrderCloseModel : AopObject
    {
        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 次卡的违约金场景里，代表商户期望收到的违约金，注意不要大于售卖订单详情接口返回的咨询结果，单位：分
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }

        /// <summary>
        /// 扣款类型
        /// </summary>
        [XmlElement("deduction_type")]
        public string DeductionType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 在次卡的违约金场景，传入订单剩余金额用于做幂等，单位：分
        /// </summary>
        [XmlElement("total_cash")]
        public long TotalCash { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
