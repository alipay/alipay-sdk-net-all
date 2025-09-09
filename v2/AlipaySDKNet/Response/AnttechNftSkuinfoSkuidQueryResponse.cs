using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftSkuinfoSkuidQueryResponse.
    /// </summary>
    public class AnttechNftSkuinfoSkuidQueryResponse : AopResponse
    {
        /// <summary>
        /// sku铸造数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 铸造数量类型
        /// </summary>
        [XmlElement("quantity_type")]
        public string QuantityType { get; set; }

        /// <summary>
        /// 藏品描述信息
        /// </summary>
        [XmlElement("sku_desc")]
        public string SkuDesc { get; set; }

        /// <summary>
        /// sku维度是否支持转增
        /// </summary>
        [XmlElement("sku_enable_send")]
        public bool SkuEnableSend { get; set; }

        /// <summary>
        /// 数字藏品类标识ID
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// sku维度缩略图
        /// </summary>
        [XmlElement("sku_mini_fileurl")]
        public string SkuMiniFileurl { get; set; }

        /// <summary>
        /// 勋章图鉴缩略图
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// Sku状态
        /// </summary>
        [XmlElement("sku_status")]
        public string SkuStatus { get; set; }

        /// <summary>
        /// sku类型
        /// </summary>
        [XmlElement("sku_type")]
        public string SkuType { get; set; }
    }
}
