using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaasBusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class SaasBusinessParams : AopObject
    {
        /// <summary>
        /// 校园卡编号
        /// </summary>
        [XmlElement("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 银行的英文简称/缩写. 主要用于网银支付单通场景, 通过此字段指定付款行. 可用的付款行可通过alipay.trade.saas.ebank.consult接口查询获取. 不指定, 返回的链接不会自动跳转支付, 需要用户页面选择唯一付款行后提交支付.
        /// </summary>
        [XmlElement("saas_ebank_bank_code")]
        public string SaasEbankBankCode { get; set; }

        /// <summary>
        /// 用户选定的用于付款的银行机构ID. 主要用于网银支付单通场景, 通过此字段指定付款行. 可用的付款行可通过alipay.trade.saas.ebank.consult接口查询获取. 不指定, 返回的链接不会自动跳转支付, 需要用户页面选择唯一付款行后提交支付.
        /// </summary>
        [XmlElement("saas_ebank_inst_id")]
        public string SaasEbankInstId { get; set; }
    }
}
