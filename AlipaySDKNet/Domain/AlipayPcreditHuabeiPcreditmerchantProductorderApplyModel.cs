using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderApplyModel : AopObject
    {
        /// <summary>
        /// 产品开始生效的时间
        /// </summary>
        [XmlElement("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 合约订购业务场景
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 下游需要数据，纯透传
        /// </summary>
        [XmlElement("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 请求来源应用
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 合约订购平台
        /// </summary>
        [XmlElement("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 订购系统码，用于标识订购花呗产品的系统
        /// </summary>
        [XmlElement("ordered_system_code")]
        public string OrderedSystemCode { get; set; }

        /// <summary>
        /// 订购产品的时间，用于标识用户下单动作的时间
        /// </summary>
        [XmlElement("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("ps_code")]
        public string PsCode { get; set; }
    }
}
