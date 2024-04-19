using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleUnfreezeResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleUnfreezeResponse : AopResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reaseon")]
        public string FailReaseon { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 解冻金额字符串
        /// </summary>
        [XmlElement("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻状态
        /// </summary>
        [XmlElement("unfreeze_status")]
        public string UnfreezeStatus { get; set; }
    }
}
