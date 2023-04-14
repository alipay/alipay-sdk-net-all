using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliverySingleMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class DeliverySingleMaterial : AopObject
    {
        /// <summary>
        /// 投放计划图片素材。通过接口alipay.marketing.material.image.upload上传图片返回的resource_id。
        /// </summary>
        [XmlElement("delivery_image")]
        public string DeliveryImage { get; set; }
    }
}
