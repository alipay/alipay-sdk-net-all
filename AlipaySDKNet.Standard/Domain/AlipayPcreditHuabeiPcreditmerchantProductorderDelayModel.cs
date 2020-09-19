using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderDelayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderDelayModel : AopObject
    {
        /// <summary>
        /// 非业务数据
        /// </summary>
        [XmlElement("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求APP
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 续订系统码，用于标识订购花呗产品的系统
        /// </summary>
        [XmlElement("renew_system_code")]
        public string RenewSystemCode { get; set; }

        /// <summary>
        /// 续订发生时间
        /// </summary>
        [XmlElement("renewing_datetime")]
        public string RenewingDatetime { get; set; }
    }
}
