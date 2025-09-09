using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowFundtradereconApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowFundtradereconApplyModel : AopObject
    {
        /// <summary>
        /// 由商户系统生成,只能包含字母,数字,下划线;商户需保证不重复.
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 与运企付约定的物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 银行分配的合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 账单日期，格式为yyyyMMdd 日期规则如下: 1. Date < Today (当日生成昨日对账单，所以申请时间需早于当日) 2. 六个月前的当月一日 <= Date 3. isv入驻时间 <= Date
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 查询账单类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
