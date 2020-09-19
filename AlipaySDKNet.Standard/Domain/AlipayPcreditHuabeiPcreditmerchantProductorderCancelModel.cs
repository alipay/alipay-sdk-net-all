using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderCancelModel : AopObject
    {
        /// <summary>
        /// 合约退订业务场景
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 退订系统码，标志退订业务来源，用于确定退订流程
        /// </summary>
        [XmlElement("cancel_system_code")]
        public string CancelSystemCode { get; set; }

        /// <summary>
        /// 退订类型
        /// </summary>
        [XmlElement("cancel_type")]
        public string CancelType { get; set; }

        /// <summary>
        /// 纯透传风控数据，由调用上游与AGDS约定好
        /// </summary>
        [XmlElement("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求APP
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 退订备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

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
    }
}
