using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseShopModel Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseShopModel : AopObject
    {
        /// <summary>
        /// 门店详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店结算银行卡信息
        /// </summary>
        [XmlArray("bank_cards")]
        [XmlArrayItem("group_purchase_bank_card")]
        public List<GroupPurchaseBankCard> BankCards { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("group_purchase_business_time")]
        public List<GroupPurchaseBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("group_purchase_shop_contact_way_info")]
        public List<GroupPurchaseShopContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 数字化门店ID
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 外部门店编号 店铺下唯一
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
        public GroupPurchaseCertificateInfo LegalInfo { get; set; }

        /// <summary>
        /// 商户主体证照信息，支持的商家账号类型：企业账号/个体工商户/民办非企业： 1.若选择企业或个体工商户，则需上传的是“营业执照信息”； 2.若选择"民办非企业"则需上传的是“民办非企业登记证书”。
        /// </summary>
        [XmlElement("license_info")]
        public GroupPurchaseShopLicenseInfo LicenseInfo { get; set; }

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
        /// 门头照图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("out_door_image")]
        public string OutDoorImage { get; set; }

        /// <summary>
        /// 证明其它材料，产权证明/租赁合同/授权材料，无营业执照三选一。
        /// </summary>
        [XmlElement("proof_info")]
        public GroupPurchaseProofInfo ProofInfo { get; set; }

        /// <summary>
        /// 门店结算信息
        /// </summary>
        [XmlArray("settle_infos")]
        [XmlArrayItem("group_purchase_settle_info")]
        public List<GroupPurchaseSettleInfo> SettleInfos { get; set; }
    }
}
