using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowSpdbTradeQueryResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowSpdbTradeQueryResultDetail : AopObject
    {
        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement("abstract_content")]
        public string AbstractContent { get; set; }

        /// <summary>
        /// 监管账户名
        /// </summary>
        [XmlElement("acct_name")]
        public string AcctName { get; set; }

        /// <summary>
        /// 实际的对手方开户行名
        /// </summary>
        [XmlElement("act_tr_th_dvc_bnk_rpttn")]
        public string ActTrThDvcBnkRpttn { get; set; }

        /// <summary>
        /// 实际的对手方行号
        /// </summary>
        [XmlElement("act_tr_th_dvry_wy_bnk_nm")]
        public string ActTrThDvryWyBnkNm { get; set; }

        /// <summary>
        /// 实际的对手方账户
        /// </summary>
        [XmlElement("act_tr_th_dvsry_wy_acct")]
        public string ActTrThDvsryWyAcct { get; set; }

        /// <summary>
        /// 实际的对手方户名
        /// </summary>
        [XmlElement("act_tr_th_dvy_wy_ccnt_nm")]
        public string ActTrThDvyWyCcntNm { get; set; }

        /// <summary>
        /// 交易实际发生日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("act_tran_date")]
        public string ActTranDate { get; set; }

        /// <summary>
        /// 标段名称
        /// </summary>
        [XmlElement("b_dstn_m")]
        public string BDstnM { get; set; }

        /// <summary>
        /// 标段号
        /// </summary>
        [XmlElement("bids_no")]
        public string BidsNo { get; set; }

        /// <summary>
        /// 渠道流水号
        /// </summary>
        [XmlElement("channel_seq_no")]
        public string ChannelSeqNo { get; set; }

        /// <summary>
        /// 子账户名
        /// </summary>
        [XmlElement("child_acct_nm")]
        public string ChildAcctNm { get; set; }

        /// <summary>
        /// 子账号
        /// </summary>
        [XmlElement("child_acct_no")]
        public string ChildAcctNo { get; set; }

        /// <summary>
        /// 核心交易日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("core_date")]
        public string CoreDate { get; set; }

        /// <summary>
        /// 借贷标志，格式：0-借/收；1-贷/付
        /// </summary>
        [XmlElement("debit_flag")]
        public string DebitFlag { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("mrch_name")]
        public string MrchName { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [XmlElement("mrch_no")]
        public string MrchNo { get; set; }

        /// <summary>
        /// 交易实际发生时间，格式：HHmmss
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [XmlElement("post_script")]
        public string PostScript { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 备用字段。rfndTransStatus:   交易状态   当系统交易类型为02或05时，交易状态枚举为00-失败 01-处理中 02-成功 03-已退汇 04-待审核 05-复核拒绝 06-签发拒绝 07-已撤销   当系统交易类型为06时，交易状态枚举为00-失败 01-处理中 02-成功
        /// </summary>
        [XmlElement("rsrv_fld")]
        public string RsrvFld { get; set; }

        /// <summary>
        /// 监管账号
        /// </summary>
        [XmlElement("settle_acct_no")]
        public string SettleAcctNo { get; set; }

        /// <summary>
        /// 系统账务流水号
        /// </summary>
        [XmlElement("sys_acntg_seq_no")]
        public string SysAcntgSeqNo { get; set; }

        /// <summary>
        /// 系统交易流水号
        /// </summary>
        [XmlElement("sys_tran_seq_no")]
        public string SysTranSeqNo { get; set; }

        /// <summary>
        /// 对手方行号
        /// </summary>
        [XmlElement("th_dvrsry_acct_bnk_nm")]
        public string ThDvrsryAcctBnkNm { get; set; }

        /// <summary>
        /// 对手方开户行名
        /// </summary>
        [XmlElement("th_dvrsry_wc_bnk_rpttn")]
        public string ThDvrsryWcBnkRpttn { get; set; }

        /// <summary>
        /// 对手方账号
        /// </summary>
        [XmlElement("th_dvrsry_wy_acct_no")]
        public string ThDvrsryWyAcctNo { get; set; }

        /// <summary>
        /// 单位为分,币种默认为人民币
        /// </summary>
        [XmlElement("tran_amt")]
        public string TranAmt { get; set; }

        /// <summary>
        /// 对手方户名
        /// </summary>
        [XmlElement("tran_cnter_nm")]
        public string TranCnterNm { get; set; }

        /// <summary>
        /// 系统交易日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("tran_date")]
        public string TranDate { get; set; }

        /// <summary>
        /// 交易机构号
        /// </summary>
        [XmlElement("tran_inst_yll")]
        public string TranInstYll { get; set; }

        /// <summary>
        /// 第三方交易流水号
        /// </summary>
        [XmlElement("tran_seq_srl_no")]
        public string TranSeqSrlNo { get; set; }

        /// <summary>
        /// 核心交易时间，格式：HHmmss
        /// </summary>
        [XmlElement("tran_time")]
        public string TranTime { get; set; }

        /// <summary>
        /// 系统交易时间，格式：HHmmss
        /// </summary>
        [XmlElement("tran_time_1")]
        public string TranTime1 { get; set; }

        /// <summary>
        /// 系统交易类型，格式：“00,01,02,...”   01-客户入金（购房交存类）   02-客户出金（退款流水，左联划款申请表）   03-不明入金   04-非客户入金   05-非客户出金   06-会员调拨
        /// </summary>
        [XmlElement("tran_tp")]
        public string TranTp { get; set; }

        /// <summary>
        /// 核心交易流水号
        /// </summary>
        [XmlElement("ylk_tran_seq_no")]
        public string YlkTranSeqNo { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
