using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceMemberInfo : AopObject
    {
        /// <summary>
        /// 金融资产链的会员地址
        /// </summary>
        [XmlElement("acct_address")]
        public string AcctAddress { get; set; }

        /// <summary>
        /// 对应于证件类型的会员证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 会员证件类型，如：100-居民身份证，231-统一社会信用代码
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 金融平台会员memberId，由dchaincustomer应用生成
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
