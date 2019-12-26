using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplySmartcountyLoaninfoQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplySmartcountyLoaninfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 前准入状态
        /// </summary>
        [XmlElement("admited")]
        public bool Admited { get; set; }

        /// <summary>
        /// 用户所在的县域编码列表，如果一个用户在三个县域中都有，则返回三个县域编码集
        /// </summary>
        [XmlArray("county_area")]
        [XmlArrayItem("string")]
        public List<string> CountyArea { get; set; }

        /// <summary>
        /// 是否是网商贷的用户
        /// </summary>
        [XmlElement("mybank_user")]
        public bool MybankUser { get; set; }

        /// <summary>
        /// 是否展示入口, 降级时候为 false
        /// </summary>
        [XmlElement("show_entrance")]
        public bool ShowEntrance { get; set; }
    }
}
