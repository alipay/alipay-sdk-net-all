using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftAssetbyskuidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftAssetbyskuidQueryModel : AopObject
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 用户id类型，参考枚举 idType
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码从1开始，默认值1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小，默认值10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商品实例id
        /// </summary>
        [XmlElement("product_instance_id")]
        public string ProductInstanceId { get; set; }

        /// <summary>
        /// 请求唯一ID，用于链路跟踪和问题排查
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 藏品标识skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
