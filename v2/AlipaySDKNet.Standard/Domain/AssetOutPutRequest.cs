using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetOutPutRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AssetOutPutRequest : AopObject
    {
        /// <summary>
        /// MD5加密或明文,落库会MD5加密
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 权益号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 景区id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }
    }
}
