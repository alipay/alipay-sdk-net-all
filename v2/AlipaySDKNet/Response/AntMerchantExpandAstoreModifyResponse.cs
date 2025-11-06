using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAstoreModifyResponse.
    /// </summary>
    public class AntMerchantExpandAstoreModifyResponse : AopResponse
    {
        /// <summary>
        /// 结算信息修改提交的申请单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
