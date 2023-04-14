using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryActivityContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryActivityContentInfo : AopObject
    {
        /// <summary>
        /// 活动id。  说明： 通过 alipay.marketing.activity.voucher.create 创建的支付券活动。  通过alipay.marketing.activity.ordervoucher.create 创建的导码模式的商家券活动。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
