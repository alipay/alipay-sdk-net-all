using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfSinglepaymentQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfSinglepaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 未还清总金额
        /// </summary>
        [XmlElement("balanceamt")]
        public AmountWf Balanceamt { get; set; }

        /// <summary>
        /// 支用编号
        /// </summary>
        [XmlElement("billno")]
        public string Billno { get; set; }

        /// <summary>
        /// 利率展示 BigDecimal*100
        /// </summary>
        [XmlElement("displayrate")]
        public string Displayrate { get; set; }

        /// <summary>
        /// 账单到期日
        /// </summary>
        [XmlElement("duedate")]
        public long Duedate { get; set; }

        /// <summary>
        /// 支用金额
        /// </summary>
        [XmlElement("encashamt")]
        public AmountWf Encashamt { get; set; }

        /// <summary>
        /// 放款机构
        /// </summary>
        [XmlElement("fipname")]
        public string Fipname { get; set; }

        /// <summary>
        /// 收款账户
        /// </summary>
        [XmlElement("grantaccount")]
        public string Grantaccount { get; set; }

        /// <summary>
        /// 未结清利息
        /// </summary>
        [XmlElement("interest")]
        public AmountWf Interest { get; set; }

        /// <summary>
        /// 未结清罚息
        /// </summary>
        [XmlElement("intpenalty")]
        public AmountWf Intpenalty { get; set; }

        /// <summary>
        /// 已结清总额
        /// </summary>
        [XmlElement("paidbillamt")]
        public AmountWf Paidbillamt { get; set; }

        /// <summary>
        /// 未结清本金
        /// </summary>
        [XmlElement("prinbalamt")]
        public AmountWf Prinbalamt { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }

        /// <summary>
        /// 支用成功时间
        /// </summary>
        [XmlElement("startdate")]
        public long Startdate { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
