using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRoyaltyRelationBatchqueryModel : AopObject
    {
        /// <summary>
        /// 外部请求号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 几页，起始页为 1。不填默认为 1。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小。每页记录数，取值范围是(0,100]。不填默认为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
