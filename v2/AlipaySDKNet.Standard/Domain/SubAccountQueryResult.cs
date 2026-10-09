using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountQueryResult : AopObject
    {
        /// <summary>
        /// 我方银行财资主户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 支付宝虚拟账号，也称2088账号
        /// </summary>
        [XmlElement("alipay_virtual_id")]
        public string AlipayVirtualId { get; set; }

        /// <summary>
        /// 全球化语言银行缩写，如：CMB
        /// </summary>
        [XmlElement("out_fin_inst_abbreviation")]
        public string OutFinInstAbbreviation { get; set; }

        /// <summary>
        /// 来源uid信息
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }

        /// <summary>
        /// INIT("INIT","账户初始化"),  APPLYING("APPLYING","账户申请中"),  ENABLE("ENABLE", "正常")  FROZEN("FROZEN", "冻结")  CLOSE("CLOSE", "销户")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子户账号
        /// </summary>
        [XmlElement("sub_account_no")]
        public string SubAccountNo { get; set; }
    }
}
