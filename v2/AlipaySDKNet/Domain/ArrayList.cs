using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArrayList Data Structure.
    /// </summary>
    [Serializable]
    public class ArrayList : AopObject
    {
        /// <summary>
        /// 未结清金额
        /// </summary>
        [XmlElement("balanceamt")]
        public AmountWf Balanceamt { get; set; }

        /// <summary>
        /// 网商支用编号
        /// </summary>
        [XmlElement("billno")]
        public string Billno { get; set; }

        /// <summary>
        /// 最晚还款日期/到期时间
        /// </summary>
        [XmlElement("duedate")]
        public string Duedate { get; set; }

        /// <summary>
        /// 支用金额
        /// </summary>
        [XmlElement("encashamt")]
        public AmountWf Encashamt { get; set; }

        /// <summary>
        /// 支用成功时间
        /// </summary>
        [XmlElement("startdate")]
        public string Startdate { get; set; }

        /// <summary>
        /// NOR：未结清 CLR：已结清 -：逾期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
