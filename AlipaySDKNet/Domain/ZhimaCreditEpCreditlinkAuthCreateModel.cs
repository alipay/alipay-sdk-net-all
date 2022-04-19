using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkAuthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkAuthCreateModel : AopObject
    {
        /// <summary>
        /// 企业可信链接协议列表
        /// </summary>
        [XmlArray("agreement_info_list")]
        [XmlArrayItem("credit_link_agreement_info")]
        public List<CreditLinkAgreementInfo> AgreementInfoList { get; set; }

        /// <summary>
        /// 授权商户ID，如果为空则使用merchant_request_id填充
        /// </summary>
        [XmlElement("auth_merchant_id")]
        public string AuthMerchantId { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("cognizant_cert_no")]
        public string CognizantCertNo { get; set; }

        /// <summary>
        /// 法人手机号
        /// </summary>
        [XmlElement("cognizant_mobile")]
        public string CognizantMobile { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("cognizant_name")]
        public string CognizantName { get; set; }

        /// <summary>
        /// 信用链接数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 授权类型，请联系服务提供方获取
        /// </summary>
        [XmlElement("link_type")]
        public string LinkType { get; set; }

        /// <summary>
        /// 商户订单号，需要商户保障唯一性
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }
    }
}
