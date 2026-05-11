using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 支付宝账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 农户身份证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 农户产粮信息列表
        /// </summary>
        [XmlArray("farmer_item_list")]
        [XmlArrayItem("recycling_farmer_item_request")]
        public List<RecyclingFarmerItemRequest> FarmerItemList { get; set; }

        /// <summary>
        /// 农户姓名
        /// </summary>
        [XmlElement("farmer_name")]
        public string FarmerName { get; set; }

        /// <summary>
        /// 农户类型
        /// </summary>
        [XmlArray("farmer_type_list")]
        [XmlArrayItem("string")]
        public List<string> FarmerTypeList { get; set; }

        /// <summary>
        /// 是否为家庭主人/家庭主导者
        /// </summary>
        [XmlElement("is_family_master")]
        public string IsFamilyMaster { get; set; }

        /// <summary>
        /// 代卖人信息
        /// </summary>
        [XmlElement("recycling_proxy")]
        public RecyclingProxyRequest RecyclingProxy { get; set; }
    }
}
