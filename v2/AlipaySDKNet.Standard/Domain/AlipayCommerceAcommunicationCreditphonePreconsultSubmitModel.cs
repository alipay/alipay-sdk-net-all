using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePreconsultSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphonePreconsultSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 套餐金额，单位：CNY
        /// </summary>
        [XmlElement("busi_level")]
        public string BusiLevel { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 是否需要身份证一致性校验，默认是false
        /// </summary>
        [XmlElement("check_cert_no")]
        public bool CheckCertNo { get; set; }

        /// <summary>
        /// 冻结金额，单位：CNY
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("inst_pid_list")]
        [XmlArrayItem("string")]
        public List<string> InstPidList { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("installment_numbers")]
        public long InstallmentNumbers { get; set; }

        /// <summary>
        /// 运营商简称，中国移动、中国电信、中国联通、中国广电
        /// </summary>
        [XmlElement("isp_abbr_cn")]
        public string IspAbbrCn { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 直降金额，单位 CNY
        /// </summary>
        [XmlElement("total_bonus")]
        public string TotalBonus { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
