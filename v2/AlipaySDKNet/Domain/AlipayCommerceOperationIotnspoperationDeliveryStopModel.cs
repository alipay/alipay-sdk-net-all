using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIotnspoperationDeliveryStopModel : AopObject
    {
        /// <summary>
        /// 枚举值： ·SELF_MODE 商户自接入模式 ·AGENCY_MODE 服务商代接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 碰一下推广计划id
        /// </summary>
        [XmlElement("n_delivery_id")]
        public string NDeliveryId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
