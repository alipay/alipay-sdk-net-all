using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsExtraCredentials Data Structure.
    /// </summary>
    [Serializable]
    public class BsExtraCredentials : AopObject
    {
        /// <summary>
        /// 饿了么品牌pid
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 意愿确认单
        /// </summary>
        [XmlElement("merchant_confirmation_letter")]
        public string MerchantConfirmationLetter { get; set; }

        /// <summary>
        /// 是否有充电宝
        /// </summary>
        [XmlElement("power_bank")]
        public bool PowerBank { get; set; }

        /// <summary>
        /// 充电宝图片
        /// </summary>
        [XmlElement("power_bank_img")]
        public string PowerBankImg { get; set; }

        /// <summary>
        /// 饿了么门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 资源服务商地推小二联系方式
        /// </summary>
        [XmlElement("supply_isv_contact_phone_no")]
        public string SupplyIsvContactPhoneNo { get; set; }

        /// <summary>
        /// 充电宝 Leads 的分层信息
        /// </summary>
        [XmlElement("supply_isv_leads_level")]
        public string SupplyIsvLeadsLevel { get; set; }
    }
}
