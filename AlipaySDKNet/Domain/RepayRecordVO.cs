using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepayRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class RepayRecordVO : AopObject
    {
        /// <summary>
        /// 还款账户
        /// </summary>
        [XmlElement("accountextno")]
        public string Accountextno { get; set; }

        /// <summary>
        /// 还款金额
        /// </summary>
        [XmlElement("repayamt")]
        public AmountWf Repayamt { get; set; }

        /// <summary>
        /// 还款时间
        /// </summary>
        [XmlElement("repaydate")]
        public long Repaydate { get; set; }

        /// <summary>
        /// 还款类型
        /// </summary>
        [XmlElement("repaytype")]
        public string Repaytype { get; set; }
    }
}
