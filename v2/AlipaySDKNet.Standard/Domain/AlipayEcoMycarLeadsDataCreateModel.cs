using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarLeadsDataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarLeadsDataCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝帐户
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 线索车辆
        /// </summary>
        [XmlElement("leads_car")]
        public LeadsCarInfo LeadsCar { get; set; }

        /// <summary>
        /// 线索城市代码
        /// </summary>
        [XmlElement("leads_city_code")]
        public string LeadsCityCode { get; set; }

        /// <summary>
        /// 线索商户
        /// </summary>
        [XmlArray("leads_merchants")]
        [XmlArrayItem("leads_merchant_info")]
        public List<LeadsMerchantInfo> LeadsMerchants { get; set; }

        /// <summary>
        /// 由支付宝方为商户进行分配
        /// </summary>
        [XmlElement("leads_source")]
        public string LeadsSource { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部线索id
        /// </summary>
        [XmlElement("out_leads_id")]
        public string OutLeadsId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
