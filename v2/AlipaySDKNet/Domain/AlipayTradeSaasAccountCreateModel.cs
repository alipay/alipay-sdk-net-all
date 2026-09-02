using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasAccountCreateModel : AopObject
    {
        /// <summary>
        /// 企业登记注册号；首次创建银行转账账户且未命中企业信息校验豁免时必填，中国大陆企业填写统一社会信用代码
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }

        /// <summary>
        /// 二级商户名称；相同外部商户号幂等重试时必须与首次一致
        /// </summary>
        [XmlElement("out_merchant_name")]
        public string OutMerchantName { get; set; }

        /// <summary>
        /// 外部平台为二级商户分配的唯一编码；同一商户 PID 下不可重复
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }
    }
}
