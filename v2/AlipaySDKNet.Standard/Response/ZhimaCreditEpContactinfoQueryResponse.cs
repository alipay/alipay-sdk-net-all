using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpContactinfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpContactinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业联系方式列表
        /// </summary>
        [XmlElement("data")]
        public EpContactInfo Data { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 企业18位统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
