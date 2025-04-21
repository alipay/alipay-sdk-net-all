using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardAftersalesQueryModel : AopObject
    {
        /// <summary>
        /// 查询订单详情或者列表的返回数据中的aftersales_id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 下单成功后的卡编号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }
    }
}
