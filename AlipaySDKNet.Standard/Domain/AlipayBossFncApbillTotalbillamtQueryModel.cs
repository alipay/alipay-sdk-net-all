using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncApbillTotalbillamtQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncApbillTotalbillamtQueryModel : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 账单关联发票状态列表{"01":"未关联","02":"部分关联","03":"完全关联"}
        /// </summary>
        [XmlArray("bill_invoice_link_statuses")]
        [XmlArrayItem("string")]
        public List<string> BillInvoiceLinkStatuses { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 月账单类型列表{"11":"应收普通日账单","12":"应收调整日账单","13":"应付普通日账单","14":"应付汇总调整日账单","15":"应付明细调整明细调整金额日账单","17":"应付普通日账单","18":"应收延迟日账单","21":"应收月账单","22":"应付月账单","23":"AP预付月账单","24":"通用记账凭证详情单","25":"应收调账月账单","26":"应收延迟月账单","31":"应收普通账单","32":"应收调账账单","33":"应收延迟账单","40":"AP付款单","41":"AP月账单"}
        /// </summary>
        [XmlArray("bill_types")]
        [XmlArrayItem("string")]
        public List<string> BillTypes { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 查询结束月份;格式yyyyMM
        /// </summary>
        [XmlElement("end_month")]
        public string EndMonth { get; set; }

        /// <summary>
        /// 分支机构ID（OU标识）
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 结算对象PID列表
        /// </summary>
        [XmlArray("ip_role_ids")]
        [XmlArrayItem("string")]
        public List<string> IpRoleIds { get; set; }

        /// <summary>
        /// 结算对象（MID）
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 结算对象mid列表
        /// </summary>
        [XmlArray("mids")]
        [XmlArrayItem("string")]
        public List<string> Mids { get; set; }

        /// <summary>
        /// 支付状态列表[01-待结算；02-部分结算；03-结算完成]
        /// </summary>
        [XmlArray("pay_statuses")]
        [XmlArrayItem("string")]
        public List<string> PayStatuses { get; set; }

        /// <summary>
        /// 产品码列表
        /// </summary>
        [XmlArray("pd_codes")]
        [XmlArrayItem("string")]
        public List<string> PdCodes { get; set; }

        /// <summary>
        /// 价格标识
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 价格政策ID
        /// </summary>
        [XmlElement("price_policy_id")]
        public string PricePolicyId { get; set; }

        /// <summary>
        /// 查询开始月份;格式yyyyMM
        /// </summary>
        [XmlElement("start_month")]
        public string StartMonth { get; set; }
    }
}
