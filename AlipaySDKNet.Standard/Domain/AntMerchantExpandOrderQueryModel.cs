using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandOrderQueryModel : AopObject
    {
        /// <summary>
        /// 申请单 id。通过https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.shop.create等接口进件时返回的order_id。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
