using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitGoodDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitGoodDetail : AopObject
    {
        /// <summary>
        /// 中台商品id(B站)
        /// </summary>
        [XmlElement("alipay_product_id")]
        public string AlipayProductId { get; set; }

        /// <summary>
        /// 商品类目id(叶子类目)
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 商品详情页url
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品有效期
        /// </summary>
        [XmlElement("expiration_date")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 扩展信息Map,存储额外的商品字段信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("key_value_map")]
        public List<KeyValueMap> ExtInfo { get; set; }

        /// <summary>
        /// 最新变更时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 商品主图url
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 商品原价，单位分（1000表示10元）
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家回传的外部产品唯一编号，用于接口幂等控制，记录映射关系
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// INIT-待上架、ONLIN-已上架销售、OFFLINE-已下架、FROZEN-已冻结、SHELF_OUT-已售罄、DELETE-已删除
        /// </summary>
        [XmlElement("out_product_status")]
        public string OutProductStatus { get; set; }

        /// <summary>
        /// 商品所属商家id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 是否处方药
        /// </summary>
        [XmlElement("prescription_drug")]
        public bool PrescriptionDrug { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("product_brand")]
        public string ProductBrand { get; set; }

        /// <summary>
        /// 如：药品69码等。创建时：商品编码为空，默认使用outProductId填充
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// 商品功能(适应症)
        /// </summary>
        [XmlElement("product_feature")]
        public string ProductFeature { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品产地
        /// </summary>
        [XmlElement("product_origin")]
        public string ProductOrigin { get; set; }

        /// <summary>
        /// 商品销售规格
        /// </summary>
        [XmlElement("product_spec")]
        public string ProductSpec { get; set; }

        /// <summary>
        /// 医药商品-MEDICAL_DRUG, 体检商品-MEDICAL_EXAMINATION, 医美商品-MEDICAL_COSMETOLOGY, 口腔商品-MEDICAL_MOUTH
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 商品所属门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 蚂蚁药saas-ALIPAY_MEDICAL_SAAS, 虎鲸saas-ORCAS_SAAS, 蚂蚁B站-ALIPAY_B
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 商品副图
        /// </summary>
        [XmlArray("sub_images")]
        [XmlArrayItem("string")]
        public List<string> SubImages { get; set; }

        /// <summary>
        /// 商品副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 适用人群
        /// </summary>
        [XmlElement("suitable_crowd")]
        public string SuitableCrowd { get; set; }
    }
}
