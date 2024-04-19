using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBaseInfo : AopObject
    {
        /// <summary>
        /// 主账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 全球化银行缩写
        /// </summary>
        [XmlElement("out_fin_inst_abbreviation")]
        public string OutFinInstAbbreviation { get; set; }

        /// <summary>
        /// 子账号
        /// </summary>
        [XmlElement("sub_account_no")]
        public string SubAccountNo { get; set; }
    }
}
