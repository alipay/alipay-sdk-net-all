using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassportHuaweimpCreateResponse.
    /// </summary>
    public class AnttechOceanbasePassportHuaweimpCreateResponse : AopResponse
    {
        /// <summary>
        /// 加密后的账号
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// true时，accountName为空 false时，accountName为实际注册使用账号
        /// </summary>
        [XmlElement("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 通行证id，用户UID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
