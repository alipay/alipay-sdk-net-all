using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineItemCreateModel : AopObject
    {
        /// <summary>
        /// 指商户创建门店后支付宝生成的门店ID
        /// </summary>
        [XmlElement("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// <a href="https://opendocs.alipay.com/mini/e2f9b4a2_alipay.open.app.delivery.info.sync?scene=common" target="_blank">alipay.open.app.delivery.info.sync</a>接口获取的履约模版id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 医保支付标签
        /// </summary>
        [XmlElement("insurance_flag")]
        public string InsuranceFlag { get; set; }

        /// <summary>
        /// 商品主图，通过图片文件上传接口<a href="https://opendocs.alipay.com/mini/3fade898_alipay.marketing.image.enhance.upload?scene=a07c8e4fcf3e490f97d959445f393b01&pathHash=a941a783" target="_blank">alipay.marketing.image.enhance.upload</a>上传图片后获取文件Id，白底、正方型、完整、组合包装正面
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 商品的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价，单位分，例如传入101代表1.01元
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品副图列表，通过图片文件上传接口<a href="https://opendocs.alipay.com/mini/3fade898_alipay.marketing.image.enhance.upload?scene=a07c8e4fcf3e490f97d959445f393b01&pathHash=a941a783" target="_blank">alipay.marketing.image.enhance.upload</a>上传图片后获取文件Id列表，白底、正方型、完整、组合包装正面
        /// </summary>
        [XmlArray("other_images")]
        [XmlArrayItem("string")]
        public List<string> OtherImages { get; set; }

        /// <summary>
        /// 外部唯一标识商品的id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 跳转商品详情的url
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 特价后的价格，单位分，例如传入100代表1元
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品上下架状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 外部标品唯一标识
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }
    }
}
