using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeCompanyConsultOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeCompanyConsultOpenApiResult : AopObject
    {
        /// <summary>
        /// 归属组织.若没有查询到关联方公司，则返回null
        /// </summary>
        [XmlElement("belong_group")]
        public string BelongGroup { get; set; }

        /// <summary>
        /// cid列表
        /// </summary>
        [XmlArray("cid_list")]
        [XmlArrayItem("string")]
        public List<string> CidList { get; set; }

        /// <summary>
        /// mid列表
        /// </summary>
        [XmlArray("mid_list")]
        [XmlArrayItem("string")]
        public List<string> MidList { get; set; }

        /// <summary>
        /// 公司名称.若没有查询到关联方公司，则返回null
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// ou短码.若没有查询到关联方公司，则返回null
        /// </summary>
        [XmlElement("ou")]
        public string Ou { get; set; }

        /// <summary>
        /// pid列表
        /// </summary>
        [XmlArray("pid_list")]
        [XmlArrayItem("string")]
        public List<string> PidList { get; set; }

        /// <summary>
        /// 是否是关联方
        /// </summary>
        [XmlElement("related_flag")]
        public bool RelatedFlag { get; set; }

        /// <summary>
        /// uid列表
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }
    }
}
