using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsCooperationResourceUrlBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCooperationResourceUrlBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求发生的时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 请求来源系统功能描述
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 来源系统ID
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 来源场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 客户唯一标志
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 资源项ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 当前操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 服务提供唯一标志
        /// </summary>
        [XmlElement("provider_code")]
        public string ProviderCode { get; set; }
    }
}
