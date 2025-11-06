using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseShopInfo : AopObject
    {
        /// <summary>
        /// 店铺银行卡信息
        /// </summary>
        [XmlArray("bank_cards")]
        [XmlArrayItem("group_purchase_bank_card")]
        public List<GroupPurchaseBankCard> BankCards { get; set; }

        /// <summary>
        /// 品牌id，通过BP站品牌工具箱可以获取品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 主营类目编码
        /// </summary>
        [XmlArray("main_business_category")]
        [XmlArrayItem("string")]
        public List<string> MainBusinessCategory { get; set; }

        /// <summary>
        /// 经营模式
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 类目资质组合列表
        /// </summary>
        [XmlArray("qualification_combines")]
        [XmlArrayItem("category_qualification_combine_info")]
        public List<CategoryQualificationCombineInfo> QualificationCombines { get; set; }

        /// <summary>
        /// 店铺结算信息
        /// </summary>
        [XmlArray("settle_infos")]
        [XmlArrayItem("group_purchase_settle_info")]
        public List<GroupPurchaseSettleInfo> SettleInfos { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlArray("shop_models")]
        [XmlArrayItem("group_purchase_shop_model")]
        public List<GroupPurchaseShopModel> ShopModels { get; set; }

        /// <summary>
        /// 商家店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店铺名字
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("store_type")]
        public string StoreType { get; set; }
    }
}
