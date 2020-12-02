using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfQuotaQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度协议书编号
        /// </summary>
        [XmlElement("agrm_bk_no")]
        public string AgrmBkNo { get; set; }

        /// <summary>
        /// 授信额度
        /// </summary>
        [XmlElement("cr_limit")]
        public string CrLimit { get; set; }

        /// <summary>
        /// 额度编号
        /// </summary>
        [XmlElement("lmt_no")]
        public string LmtNo { get; set; }

        /// <summary>
        /// 额度状态
        /// </summary>
        [XmlElement("lmt_status")]
        public string LmtStatus { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        [XmlElement("remain_limit")]
        public string RemainLimit { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trans_no")]
        public string TransNo { get; set; }
    }
}
