using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAssetAuthorizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAssetAuthorizeQueryModel : AopObject
    {
        /// <summary>
        /// 通过企业码1.0接口签约的共同账户，和agreement_no搭配使用。 当前字段已废弃(历史兼容逻辑冗余的字段统一移除)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 可通过签约消息获取。配合共同账户id使用，当填写企业共同账户id时，此字段必填。 当前字段已废弃(历史兼容逻辑冗余的字段统一移除)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业统一社会信用代码，与enterprise_id二选一
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业码内部自动生成企业唯一标识，与enterprise_code二选一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 授信申请时传入的外部业务单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
