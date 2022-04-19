using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantTradecomplainSupplementSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantTradecomplainSupplementSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 回复内容，最多不超过200个字
        /// </summary>
        [XmlElement("supplement_content")]
        public string SupplementContent { get; set; }

        /// <summary>
        /// 商家补充凭证时的图片id，多个逗号隔开（图片id可以通过"商户上传处理图片"接口获取）
        /// </summary>
        [XmlElement("supplement_images")]
        public string SupplementImages { get; set; }
    }
}
