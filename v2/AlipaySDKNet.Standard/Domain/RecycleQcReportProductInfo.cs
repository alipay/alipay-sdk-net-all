using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportProductInfo : AopObject
    {
        /// <summary>
        /// 用户下单前的预估价格，单位为元，最多两位小数
        /// </summary>
        [XmlElement("estimated_price")]
        public string EstimatedPrice { get; set; }

        /// <summary>
        /// 3C设备的IMEI码
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 物品是否符合回收标准。为true时需要给出报价信息
        /// </summary>
        [XmlElement("is_recycle")]
        public bool IsRecycle { get; set; }

        /// <summary>
        /// 产品编码，支付宝商品库定义，并在下单时回传给服务商。用户实际寄出的商品，可能和问卷不一致，需要按传入收到商品的产品编码，可能和用户下单的编码不一致。 - 品一致，传下单的product_code - 品不一致且在支付宝商品库，传实际product_code - 品不在支付宝商品库，传 UNDEFINED
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品logo图片id。当产品不在支付宝产品库时，需要传入
        /// </summary>
        [XmlElement("product_image_id")]
        public string ProductImageId { get; set; }

        /// <summary>
        /// 产品名称。 - 品在支付宝商品库，传code对应的product_name - 品不在支付宝商品库，传实际product_name和product_image_id
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 质检之后最终报价，单位为元，最多两位小数
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// sku_id。支付宝下单时传给商户，每件商品一个id。多件场景下，每件商品一份报告； 非多件场景，无需传入
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
