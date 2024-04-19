using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeaseItemSkuDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LeaseItemSkuDTO : AopObject
    {
        /// <summary>
        /// 品牌方pid
        /// </summary>
        [XmlElement("brand_pid")]
        public string BrandPid { get; set; }

        /// <summary>
        /// 品牌方skuid
        /// </summary>
        [XmlElement("brand_sku_id")]
        public string BrandSkuId { get; set; }

        /// <summary>
        /// sku租赁价格
        /// </summary>
        [XmlElement("lease_price")]
        public string LeasePrice { get; set; }

        /// <summary>
        /// 租赁商品跳转地址
        /// </summary>
        [XmlElement("lessor_path")]
        public string LessorPath { get; set; }

        /// <summary>
        /// 租赁商pid
        /// </summary>
        [XmlElement("lessor_pid")]
        public string LessorPid { get; set; }

        /// <summary>
        /// 租赁商品skuid
        /// </summary>
        [XmlElement("lessor_sku_id")]
        public string LessorSkuId { get; set; }

        /// <summary>
        /// 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
