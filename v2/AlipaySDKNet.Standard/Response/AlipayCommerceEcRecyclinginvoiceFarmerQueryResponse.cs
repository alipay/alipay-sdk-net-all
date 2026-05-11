using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceFarmerQueryResponse : AopResponse
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
        /// 农户代卖人关系确认状态
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 农户授权链接
        /// </summary>
        [XmlElement("farmer_auth_url")]
        public string FarmerAuthUrl { get; set; }

        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }

        /// <summary>
        /// 农户产粮信息列表
        /// </summary>
        [XmlArray("farmer_item_list")]
        [XmlArrayItem("recycling_farmer_item_result")]
        public List<RecyclingFarmerItemResult> FarmerItemList { get; set; }

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
        /// 代卖人身份证件号
        /// </summary>
        [XmlElement("proxy_cert_no")]
        public string ProxyCertNo { get; set; }

        /// <summary>
        /// 代卖人姓名
        /// </summary>
        [XmlElement("proxy_name")]
        public string ProxyName { get; set; }
    }
}
