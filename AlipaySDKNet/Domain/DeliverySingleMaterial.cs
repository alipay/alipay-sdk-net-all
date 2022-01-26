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
        /// 投放计划图片素材。通过接口alipay.marketing.material.image.upload上传图片返回的resource_id，上传接口需指定file_key为DELIVERY_CHANNEL_PIC。上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过200kb。上传图片更多要求参考文档： https://render.alipay.com/p/c/18tpirlg12e8?operateFrom=BALIPAY。
        /// </summary>
        [XmlElement("delivery_image")]
        public string DeliveryImage { get; set; }
    }
}
