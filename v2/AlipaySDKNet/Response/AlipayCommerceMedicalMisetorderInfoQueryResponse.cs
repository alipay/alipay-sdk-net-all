using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMisetorderInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMisetorderInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 人员证书编号，用于唯一标识证书。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 清算经办机构（清算分中心 医保中心返回）
        /// </summary>
        [XmlElement("clr_optins")]
        public string ClrOptins { get; set; }

        /// <summary>
        /// 清算类别
        /// </summary>
        [XmlElement("clr_type")]
        public string ClrType { get; set; }

        /// <summary>
        /// 人员参保地区划
        /// </summary>
        [XmlElement("insuplc_admdvs")]
        public string InsuplcAdmdvs { get; set; }

        /// <summary>
        /// 险种类型 [   {"name": "职工基本医疗保险", "value": "310"},   {"name": "城乡居民基本医疗保险", "value": "390"},   {"name": "公务员医疗补助", "value": "320"},   {"name": "城乡居民大病医疗保险", "value": "392"},   {"name": "大额医疗费用补助", "value": "330"},   {"name": "生育保险", "value": "510"},   {"name": "离休人员医疗保障", "value": "340"} ]
        /// </summary>
        [XmlElement("insutype")]
        public string Insutype { get; set; }

        /// <summary>
        /// 门诊/住院流水号(医保门诊挂号/入院办理返回的就诊 id)
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 医疗类别
        /// </summary>
        [XmlElement("med_type")]
        public string MedType { get; set; }

        /// <summary>
        /// 医疗总费用
        /// </summary>
        [XmlElement("medfee_sumamt")]
        public string MedfeeSumamt { get; set; }

        /// <summary>
        /// 医保个账金额，个人账户支出
        /// </summary>
        [XmlElement("mi_personal_amt")]
        public string MiPersonalAmt { get; set; }

        /// <summary>
        /// 医保统筹金额，基金支付总额
        /// </summary>
        [XmlElement("mi_pool_amt")]
        public string MiPoolAmt { get; set; }

        /// <summary>
        /// 支付结算信息
        /// </summary>
        [XmlElement("pay_settle_info")]
        public ExtendData PaySettleInfo { get; set; }

        /// <summary>
        /// 个人现金，单位元
        /// </summary>
        [XmlElement("psn_cash_pay")]
        public string PsnCashPay { get; set; }

        /// <summary>
        /// 01-身份证
        /// </summary>
        [XmlElement("psn_cert_type")]
        public string PsnCertType { get; set; }

        /// <summary>
        /// 人员姓名，信息脱敏。
        /// </summary>
        [XmlElement("psn_name")]
        public string PsnName { get; set; }

        /// <summary>
        /// 人员编号
        /// </summary>
        [XmlElement("psn_no")]
        public string PsnNo { get; set; }

        /// <summary>
        /// 退款流程中的结算ID，可能没有
        /// </summary>
        [XmlElement("refund_set_id")]
        public string RefundSetId { get; set; }

        /// <summary>
        /// 退款结算时间，退款才有，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("refund_set_time")]
        public string RefundSetTime { get; set; }

        /// <summary>
        /// 医保退款信息
        /// </summary>
        [XmlElement("refund_settle_info")]
        public ExtendData RefundSettleInfo { get; set; }

        /// <summary>
        /// 医保结算ID
        /// </summary>
        [XmlElement("set_id")]
        public string SetId { get; set; }

        /// <summary>
        /// 2025-03-24 15:54:02 结算时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("set_time")]
        public string SetTime { get; set; }

        /// <summary>
        /// 医保国际编码，医保机构编码
        /// </summary>
        [XmlElement("store_mi_code")]
        public string StoreMiCode { get; set; }
    }
}
