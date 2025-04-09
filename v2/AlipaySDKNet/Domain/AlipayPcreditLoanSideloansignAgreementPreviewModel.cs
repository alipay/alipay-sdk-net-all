using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignAgreementPreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignAgreementPreviewModel : AopObject
    {
        /// <summary>
        /// 指定agreementList以动态渲染和预览对应的协议合同内容
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("agreeement_pre_view_req")]
        public List<AgreeementPreViewReq> AgreementList { get; set; }

        /// <summary>
        /// 信贷业务场景类型Code
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// SIMPLE_CREDIT极简授信
        /// </summary>
        [XmlElement("credit_type")]
        public string CreditType { get; set; }

        /// <summary>
        /// 部分协议内容展示需要上游咨询结果信息, 以及用户提交前填写的动态字段, 需要在参扩展信息中透传
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 出资机构机构ID
        /// </summary>
        [XmlElement("fund_supplier_code")]
        public string FundSupplierCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
