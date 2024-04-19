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
        /// 通过企业码1.0接口签约的共同账户，和agreement_no搭配使用。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 可通过签约消息获取。配合共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 通过企业码2.0签约接口签约，只填写企业id，无需填写共同账户id和授权签约协议号。
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
