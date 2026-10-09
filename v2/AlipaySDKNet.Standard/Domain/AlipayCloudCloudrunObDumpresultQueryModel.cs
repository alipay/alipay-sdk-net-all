using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObDumpresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObDumpresultQueryModel : AopObject
    {
        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 查询页码，第一页传参数1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 查询列表的页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 四种状态，"WAITING"、"RUNNING"、"FINISH"、"EXPIRE"可传
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 创建任务的用户名
        /// </summary>
        [XmlArray("user_name_list")]
        [XmlArrayItem("string")]
        public List<string> UserNameList { get; set; }
    }
}
