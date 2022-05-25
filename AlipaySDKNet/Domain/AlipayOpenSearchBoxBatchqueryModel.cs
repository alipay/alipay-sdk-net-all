using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 分页查询的当前页号,从1开始
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页查询的数量，默认10，不得超过50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
