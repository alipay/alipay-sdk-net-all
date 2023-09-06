using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceModifyAfterDistributeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceModifyAfterDistributeDTO : AopObject
    {
        /// <summary>
        /// 修改参数
        /// </summary>
        [XmlElement("input_invoice_modify_open_api_dto")]
        public InputInvoiceModifyOpenApiDTO InputInvoiceModifyOpenApiDto { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 请求号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
