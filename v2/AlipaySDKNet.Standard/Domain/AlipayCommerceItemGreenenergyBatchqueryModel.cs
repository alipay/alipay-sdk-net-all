using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceItemGreenenergyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceItemGreenenergyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 绿色能量发放归属的商户信息。 说明： 如果该复杂对象不填。则默认为该绿色能量发放的归属者是调用者本人。 如果填写，则认为该绿色能量发放的归属者是该商户。 限制:服务商身份接入时必传
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongGreenMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 能量状态： 0.待领取；1.已领取. 默认返回所有记录
        /// </summary>
        [XmlElement("energy_status")]
        public long EnergyStatus { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [XmlElement("paginator")]
        public GreenPaginator Paginator { get; set; }
    }
}
