using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransReceiptApplyResponse.
    /// </summary>
    public class AlipayCommerceEcTransReceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件申请号file_id信息。使用file_id可以查询处理状态，有效期2天
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
