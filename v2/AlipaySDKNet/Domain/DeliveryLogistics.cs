using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryLogistics Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryLogistics : AopObject
    {
        /// <summary>
        /// ALREADY_DELIVER:已发货，RECEIVED:已签收，SIGN_FAILED:签收失败
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("express_company_name")]
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 物流编号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 物流轨迹查看页面的跳转地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
