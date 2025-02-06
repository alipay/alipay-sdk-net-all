using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataImAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataImAddModel : AopObject
    {
        /// <summary>
        /// 问诊订单回流接口出参的order_id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// out_biz_no，唯一，外部商户自有问诊订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部im会话chatId
        /// </summary>
        [XmlElement("out_chat_id")]
        public string OutChatId { get; set; }

        /// <summary>
        /// 加人列表
        /// </summary>
        [XmlArray("service_providers")]
        [XmlArrayItem("service_provider")]
        public List<ServiceProvider> ServiceProviders { get; set; }
    }
}
