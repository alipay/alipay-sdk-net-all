using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDataproductFourelementMatchResponse.
    /// </summary>
    public class ZhimaCreditEpDataproductFourelementMatchResponse : AopResponse
    {
        /// <summary>
        /// 企业四要素匹配展示的企业基本信息
        /// </summary>
        [XmlElement("basic_info")]
        public EntBasicInfo BasicInfo { get; set; }

        /// <summary>
        /// 企业统一社会信用代码，和入参保持一致
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企业名称，和入参保持一致
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 法人证件号，和入参保证一致
        /// </summary>
        [XmlElement("fr_cert_no")]
        public string FrCertNo { get; set; }

        /// <summary>
        /// 法人姓名，和入参保证一致
        /// </summary>
        [XmlElement("fr_name")]
        public string FrName { get; set; }

        /// <summary>
        /// 四要素匹配结果
        /// </summary>
        [XmlElement("match_code")]
        public string MatchCode { get; set; }

        /// <summary>
        /// 用户输入了企业统一社会信用代码、法人姓名、法人证件号不匹配
        /// </summary>
        [XmlArray("match_result_columns")]
        [XmlArrayItem("string")]
        public List<string> MatchResultColumns { get; set; }

        /// <summary>
        /// 企业注册号，和入参保持一致
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }
    }
}
