using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOpensearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasOpensearchQueryModel : AopObject
    {
        /// <summary>
        /// 搜索的领域，不传默认全部all
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 搜索每页的文档数，不填默认20
        /// </summary>
        [XmlElement("pagesize")]
        public long Pagesize { get; set; }

        /// <summary>
        /// 搜索用的关键词
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 业务分配的scene值
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// debug表示开启调度模式,default或为空表示不开启
        /// </summary>
        [XmlElement("searchmode")]
        public string Searchmode { get; set; }
    }
}
