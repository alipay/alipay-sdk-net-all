using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAuthorizetransferApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowAuthorizetransferApplyResponse : AopResponse
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
        /// 合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// SUCCESS(受理成功)，FAIL(受理失败)，UNKNOWN(受理未知) SUCCESS代表受理成功，后续通过查询接口拿到最终的处理结果 FAIL代表受理失败 UNKNOWN代表结果未知，不能判断为受理成功或者失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
