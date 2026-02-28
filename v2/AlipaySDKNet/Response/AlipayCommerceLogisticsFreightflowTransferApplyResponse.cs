using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTransferApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowTransferApplyResponse : AopResponse
    {
        /// <summary>
        /// 银行操作单号(查询时需要使用)
        /// </summary>
        [XmlElement("bank_operate_no")]
        public string BankOperateNo { get; set; }

        /// <summary>
        /// 业务幂等号(同入参中的业务幂等号一致)
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 手续费,单位为'分',mode为浦发银行时可能包含手续费
        /// </summary>
        [XmlElement("charges")]
        public string Charges { get; set; }

        /// <summary>
        /// 手续费承担方
        /// </summary>
        [XmlElement("charges_payer")]
        public string ChargesPayer { get; set; }

        /// <summary>
        /// 合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 当mode为网商银行时： SUCCESS(受理成功)，FAIL(受理失败)，UNKNOWN(受理未知) SUCCESS代表受理成功，后续通过查询接口拿到最终的处理结果 FAIL代表受理失败 UNKNOWN代表结果未知，不能判断为受理成功或者失败  当mode为浦发银行时： SUCCESS代表转账成功 FAIL代表转账失败 DEALING代表转账处理中 UNKNOWN代表转账状态未知,可联系工作人员进行确认
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
