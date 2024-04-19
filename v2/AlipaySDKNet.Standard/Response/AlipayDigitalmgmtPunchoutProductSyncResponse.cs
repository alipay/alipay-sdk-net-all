using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutProductSyncResponse.
    /// </summary>
    public class AlipayDigitalmgmtPunchoutProductSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回值信息
        /// </summary>
        [XmlArray("ret_value")]
        [XmlArrayItem("string")]
        public List<string> RetValue { get; set; }

        /// <summary>
        /// 组合的异常信息
        /// </summary>
        [XmlElement("sync_error_msg")]
        public string SyncErrorMsg { get; set; }

        /// <summary>
        /// false 时详见 ret_value 的同步异常产品
        /// </summary>
        [XmlElement("sync_flag")]
        public bool SyncFlag { get; set; }
    }
}
