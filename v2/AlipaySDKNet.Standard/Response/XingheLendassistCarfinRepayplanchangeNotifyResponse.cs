using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinRepayplanchangeNotifyResponse.
    /// </summary>
    public class XingheLendassistCarfinRepayplanchangeNotifyResponse : AopResponse
    {
        /// <summary>
        /// 还款计划更新信息
        /// </summary>
        [XmlElement("repayplan_content")]
        public string RepayplanContent { get; set; }
    }
}
