using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 收端用户的收款卡号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 银行机构英文名字
        /// </summary>
        [XmlElement("bank_english_name")]
        public string BankEnglishName { get; set; }

        /// <summary>
        /// 银行的机构Id
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 是否有同步返回结果
        /// </summary>
        [XmlElement("has_sync_result")]
        public bool HasSyncResult { get; set; }
    }
}
