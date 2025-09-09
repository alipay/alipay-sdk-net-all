using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PharmacistVO Data Structure.
    /// </summary>
    [Serializable]
    public class PharmacistVO : AopObject
    {
        /// <summary>
        /// 合作方外部门店编码
        /// </summary>
        [XmlElement("app_store_code")]
        public string AppStoreCode { get; set; }

        /// <summary>
        /// 组织渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 平台药师编码
        /// </summary>
        [XmlElement("pharmacist_code")]
        public string PharmacistCode { get; set; }

        /// <summary>
        /// 门店药师姓名
        /// </summary>
        [XmlElement("pharmacist_name")]
        public string PharmacistName { get; set; }

        /// <summary>
        /// 药师状态；1-有效；2-无效
        /// </summary>
        [XmlElement("pharmacist_status")]
        public string PharmacistStatus { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
