using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryResponse.
    /// </summary>
    public class AlipayPcreditCreditriskCustlabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否展示借呗
        /// </summary>
        [XmlElement("show_jb")]
        public bool ShowJb { get; set; }

        /// <summary>
        /// 是否展示网商
        /// </summary>
        [XmlElement("show_my")]
        public bool ShowMy { get; set; }
    }
}
