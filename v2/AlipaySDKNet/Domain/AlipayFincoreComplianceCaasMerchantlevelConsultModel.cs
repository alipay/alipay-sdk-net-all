using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCaasMerchantlevelConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceCaasMerchantlevelConsultModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 调用caas分配的appkey
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 用于调用的管控
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 调用caas的事件code
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 订单笔数
        /// </summary>
        [XmlElement("order_count")]
        public long OrderCount { get; set; }

        /// <summary>
        /// traceid
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 18位统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
