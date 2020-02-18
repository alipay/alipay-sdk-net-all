using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillEreceiptApplyResponse.
    /// </summary>
    public class AlipayDataBillEreceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件申请号file_id信息。使用file_id可以查询处理状态
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
