using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpEntity Data Structure.
    /// </summary>
    [Serializable]
    public class CorpEntity : AopObject
    {
        /// <summary>
        /// 企业支付宝登录账号(邮箱或手机号)
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 企业统一社会信用编码
        /// </summary>
        [XmlElement("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// xxx测试公司
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }
    }
}
