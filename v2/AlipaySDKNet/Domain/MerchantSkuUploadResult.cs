using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSkuUploadResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSkuUploadResult : AopObject
    {
        /// <summary>
        /// 商家侧商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧SKUID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 上传结果状态。返回SPU_NOT_EXSIT和 CSPU_NOT_EXSIT不存在时，需要联系BD确认品类是否正确，确认完成后可以重试
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
