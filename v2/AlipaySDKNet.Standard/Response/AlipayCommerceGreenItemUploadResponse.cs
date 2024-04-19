using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGreenItemUploadResponse.
    /// </summary>
    public class AlipayCommerceGreenItemUploadResponse : AopResponse
    {
        /// <summary>
        /// 失败的能量码操作日志
        /// </summary>
        [XmlArray("failed_qr_code_log_list")]
        [XmlArrayItem("qr_code_operation_log")]
        public List<QrCodeOperationLog> FailedQrCodeLogList { get; set; }
    }
}
