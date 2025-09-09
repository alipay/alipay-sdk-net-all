using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandSceneOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandSceneOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误原因
        /// </summary>
        [XmlElement("fail_reasons")]
        public MerchantSceneRoleFailInfo FailReasons { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
