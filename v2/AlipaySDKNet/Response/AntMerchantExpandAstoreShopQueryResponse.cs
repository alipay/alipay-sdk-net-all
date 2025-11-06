using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAstoreShopQueryResponse.
    /// </summary>
    public class AntMerchantExpandAstoreShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }

        /// <summary>
        /// 门店详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店结算银行卡信息
        /// </summary>
        [XmlArray("bank_cards")]
        [XmlArrayItem("shop_bank_card")]
        public List<ShopBankCard> BankCards { get; set; }

        /// <summary>
        /// 品牌连锁店时brand_id才返回品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("a_shop_business_time")]
        public List<AShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("shop_contact_way_info")]
        public List<ShopContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 数字化门店ID
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 外部门店编号，店铺下唯一
        /// </summary>
        [XmlElement("external_no")]
        public string ExternalNo { get; set; }

        /// <summary>
        /// 门店维度，度（degrees）为单位
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 法人证照身份证信息
        /// </summary>
        [XmlElement("legal_info")]
        public ShopCertificateInfo LegalInfo { get; set; }

        /// <summary>
        /// 商户主体证照信息
        /// </summary>
        [XmlElement("license_info")]
        public ShopLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 门店经度,以度（degrees）为单位
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// mcc一级类目
        /// </summary>
        [XmlElement("mcc_l_1")]
        public string MccL1 { get; set; }

        /// <summary>
        /// mcc二级类目
        /// </summary>
        [XmlElement("mcc_l_2")]
        public string MccL2 { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门头照图片
        /// </summary>
        [XmlElement("out_door_image")]
        public string OutDoorImage { get; set; }

        /// <summary>
        /// 证明其它材料
        /// </summary>
        [XmlElement("proof_info")]
        public ShopProofInfo ProofInfo { get; set; }

        /// <summary>
        /// 门店备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 门店结算信息
        /// </summary>
        [XmlArray("settle_infos")]
        [XmlArrayItem("shop_settle_info")]
        public List<ShopSettleInfo> SettleInfos { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 目前仅支持GROUP_BUY
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
