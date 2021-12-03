using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpIsvBillSyncResponse.
    /// </summary>
    public class AlipayOpenSpIsvBillSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回true或者flase，ture代表账单回传成功，false表示账单回传失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
