using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderTransferModel : AopObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 补充字段
        /// </summary>
        [XmlElement("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("inactive_datetime")]
        public string InactiveDatetime { get; set; }

        /// <summary>
        /// 退订接受时间
        /// </summary>
        [XmlElement("inactiving_datetime")]
        public string InactivingDatetime { get; set; }

        /// <summary>
        /// 订购原来
        /// </summary>
        [XmlElement("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 订购系统码
        /// </summary>
        [XmlElement("ordered_system_code")]
        public string OrderedSystemCode { get; set; }

        /// <summary>
        /// 接受订购时间
        /// </summary>
        [XmlElement("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 商户支付宝ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// 续订标志
        /// </summary>
        [XmlElement("renew")]
        public string Renew { get; set; }

        /// <summary>
        /// 原淘宝服务市场订购单号
        /// </summary>
        [XmlElement("taobao_order_id")]
        public string TaobaoOrderId { get; set; }
    }
}
