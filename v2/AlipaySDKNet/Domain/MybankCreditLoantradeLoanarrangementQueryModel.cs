using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarrangementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanarrangementQueryModel : AopObject
    {
        /// <summary>
        /// 网商银行参与者会员角色ID。客户在网商融资平台页面发起贷款申请或者机构调用代客户申贷接口mybank.credit.loanapply.apply.create后，网商会把申请结果以消息的方式通知机构，该字段包含在返回的消息体中。
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 合约编号，客户签署合约时获取。
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_scene_code")]
        public string MybkAuthSceneCode { get; set; }

        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_token")]
        public string MybkAuthToken { get; set; }
    }
}
