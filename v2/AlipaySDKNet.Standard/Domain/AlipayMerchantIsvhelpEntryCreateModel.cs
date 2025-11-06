using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIsvhelpEntryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIsvhelpEntryCreateModel : AopObject
    {
        /// <summary>
        /// 受益人是否是法人。如果是，则受益人信息可以不用填写
        /// </summary>
        [XmlElement("beneficiary_is_legal")]
        public bool BeneficiaryIsLegal { get; set; }

        /// <summary>
        /// 入驻信息，扩展信息 目前支持的key如下 1.   MERCHANT_MCC  行业类目,多个逗号分隔 2.   MERCHANT_CONTACT_PHONE 联系手机号 3.   BRAND_NAME   品牌方名称 4.   ISV_HAVANAL_ID   HAVANA_ID   5.  ISV_CLIENT_IP  客户端ip
        /// </summary>
        [XmlElement("ext_info")]
        public ExtInfoMap ExtInfo { get; set; }

        /// <summary>
        /// 服务商自定义的申请编号，每个申请编号唯一对应一个申请单，需在服务商下唯一。只能用数字、字母或下划线组成
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受益所有人信息
        /// </summary>
        [XmlElement("merchant_entry_beneficiary_info")]
        public MerchantEntryBeneficiaryInfo MerchantEntryBeneficiaryInfo { get; set; }

        /// <summary>
        /// 法定代表人信息
        /// </summary>
        [XmlElement("merchant_entry_legal_info")]
        public MerchantEntryLegalInfo MerchantEntryLegalInfo { get; set; }

        /// <summary>
        /// 商家入驻主体信息
        /// </summary>
        [XmlElement("merchant_entry_org_info")]
        public MerchantEntryOrgInfo MerchantEntryOrgInfo { get; set; }
    }
}
