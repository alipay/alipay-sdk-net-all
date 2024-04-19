using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityIotdeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public IotDeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 投放计划id。与out_biz_no参数二选一
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 外部业务单号，与投放计划id一一对应。与delivery_id参数二选一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
