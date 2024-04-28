using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPhoneRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPhoneRiskInfo : AopObject
    {
        /// <summary>
        /// 分公司
        /// </summary>
        [XmlElement("branch_company")]
        public string BranchCompany { get; set; }

        /// <summary>
        /// true有，false无
        /// </summary>
        [XmlElement("contract_reg_cust_flag")]
        public bool ContractRegCustFlag { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("merchant_addr")]
        public string MerchantAddr { get; set; }

        /// <summary>
        /// 门店在运营商内部ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 单位是元。近半年每月消费额度X元
        /// </summary>
        [XmlElement("monetary_6m")]
        public string Monetary6m { get; set; }

        /// <summary>
        /// 网龄。用户在网年份
        /// </summary>
        [XmlElement("net_age")]
        public long NetAge { get; set; }

        /// <summary>
        /// 进件员工ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 业务受理时间。与调用我们的下单时间注意区分。这是用户决定办理业务的时间
        /// </summary>
        [XmlElement("service_accept_time")]
        public string ServiceAcceptTime { get; set; }

        /// <summary>
        /// 子机构支付宝登录号
        /// </summary>
        [XmlElement("sub_alipay_account")]
        public string SubAlipayAccount { get; set; }

        /// <summary>
        /// 门店支付宝账号
        /// </summary>
        [XmlElement("sub_pid")]
        public string SubPid { get; set; }

        /// <summary>
        /// 套餐合约手机号的机主姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
