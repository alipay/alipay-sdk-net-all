using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportInstbillQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportInstbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// "utility_" + uniqId，缓存的账单的key，每次查询均保证唯一性，但是不保证幂等性，在创建时需要透传回支付宝这边。
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 缴费模式:2-账单模式;4-缴清欠费模式;5-欠费自由缴模式。
        /// </summary>
        [XmlElement("charge_mode")]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构账单列表，如果有多条，只允许选择其中的一条进行支付。
        /// </summary>
        [XmlArray("inst_bills")]
        [XmlArrayItem("jf_export_inst_bill_model")]
        public List<JfExportInstBillModel> InstBills { get; set; }

        /// <summary>
        /// 账单拥有者姓名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 子业务类型英文简称
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
