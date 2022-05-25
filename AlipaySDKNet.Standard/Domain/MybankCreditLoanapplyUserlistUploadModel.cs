using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyUserlistUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyUserlistUploadModel : AopObject
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 外部机构编码(ISV注册成为网商银行的会员，ISV在网商的会员ID)
        /// </summary>
        [XmlElement("dataorgid")]
        public string Dataorgid { get; set; }

        /// <summary>
        /// 数据提供者,ISV注册成为网商银行的会员，达成数据合作服务，约定数据模型，由网商分配给ISV的机构代号
        /// </summary>
        [XmlElement("dataprovider")]
        public string Dataprovider { get; set; }

        /// <summary>
        /// 数据加密类型
        /// </summary>
        [XmlElement("encryption_type")]
        public string EncryptionType { get; set; }

        /// <summary>
        /// 名单详细列表
        /// </summary>
        [XmlArray("list_info")]
        [XmlArrayItem("list_detail")]
        public List<ListDetail> ListInfo { get; set; }
    }
}
