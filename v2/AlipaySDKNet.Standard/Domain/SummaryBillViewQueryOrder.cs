using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryBillViewQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryBillViewQueryOrder : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单结束月份
        /// </summary>
        [XmlElement("bill_end_month")]
        public string BillEndMonth { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [XmlArray("bill_nos")]
        [XmlArrayItem("string")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 账单月份
        /// </summary>
        [XmlElement("bill_start_month")]
        public string BillStartMonth { get; set; }

        /// <summary>
        /// 账单状态 UNCHECKED("unchecked", "未出账"),      PARTIAL_CHECK("partial_checked","部分出账"),      CHECKED("checked", "已出账"),      CONFIRMED("confirmed", "账单已确认");
        /// </summary>
        [XmlElement("bill_status_list")]
        public string BillStatusList { get; set; }

        /// <summary>
        /// 业务产品码列表
        /// </summary>
        [XmlArray("biz_pd_code_list")]
        [XmlArrayItem("string")]
        public List<string> BizPdCodeList { get; set; }

        /// <summary>
        /// 资金结算时点
        /// </summary>
        [XmlElement("fund_settle_time")]
        public string FundSettleTime { get; set; }

        /// <summary>
        /// 机构OU
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示数，分页时必须提供 【必填】
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 付款方pid
        /// </summary>
        [XmlElement("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 结算对象pidList
        /// </summary>
        [XmlArray("settle_ip_role_id_list")]
        [XmlArrayItem("string")]
        public List<string> SettleIpRoleIdList { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [XmlArray("settle_status_list")]
        [XmlArrayItem("string")]
        public List<string> SettleStatusList { get; set; }

        /// <summary>
        /// 结算时点类型 real、delayed
        /// </summary>
        [XmlArray("settle_time_type_list")]
        [XmlArrayItem("string")]
        public List<string> SettleTimeTypeList { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 扩展汇总维度1 （智科业务是：外部合约号outContractId，前端给到参数“outContractId=XXXX”)
        /// </summary>
        [XmlElement("summary_dmsn_1")]
        public string SummaryDmsn1 { get; set; }
    }
}
