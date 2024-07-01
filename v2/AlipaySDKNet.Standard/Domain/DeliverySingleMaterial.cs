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
        /// 投放计划图片素材。通过接口<a href ="https://opendocs.alipay.com/open/049d64?pathHash=a411214d&scene=928cd58dc06f4466b9ad657776327a06">alipay.marketing.material.image.upload</a>上传图片返回的resource_id。
        /// </summary>
        [XmlElement("delivery_image")]
        public string DeliveryImage { get; set; }
    }
}
