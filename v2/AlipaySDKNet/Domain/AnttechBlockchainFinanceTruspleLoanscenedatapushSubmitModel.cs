using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleLoanscenedatapushSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTruspleLoanscenedatapushSubmitModel : AopObject
    {
        /// <summary>
        /// 人民币:CNY 美元:USD
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 借款金额
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 外部机构的会员Id，用于在Trusple侧进行登录
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 附言备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 收款人账户
        /// </summary>
        [XmlElement("receiver_account_no")]
        public string ReceiverAccountNo { get; set; }

        /// <summary>
        /// 开户行银行编码 示例:       中国银行:BKCHCNBJ,       中国工商银行:ICBKCNBJ,       中国农业银行:ABOCCNBJ,       中国建设银行:PCBCCNBJ,       中国交通银行:COMMCNSH,       邮储银行:PSBCCNBJ,       兴业银行:FJIBCNBA,       招商银行:CMBCCNBS,       平安银行:SZDBCNBS,       上海浦东发展银行:SPDBCNSH,       中信银行:CIBKCNBJ,       民生银行:MSBCCNBJ,       华夏银行:HXBKCNBJ,       上海银行:BOSHCNSH,       北京银行:BJCNCNBJ,       宁波银行:BKNBCN2N,       中国光大银行:EVERCNBJ,       徽商银行:HFCBCNSH,       浙商银行:ZJCBCN2N,       广发银行:GDBKCN22,       渤海银行:CHBHCNBT,       汇丰银行(中国):HSBCCNSH
        /// </summary>
        [XmlElement("receiver_bank_code")]
        public string ReceiverBankCode { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 幂等id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
