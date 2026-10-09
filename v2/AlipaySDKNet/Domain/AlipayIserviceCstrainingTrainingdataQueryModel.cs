using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCstrainingTrainingdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCstrainingTrainingdataQueryModel : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 路径id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 路径名称
        /// </summary>
        [XmlElement("path_name")]
        public string PathName { get; set; }

        /// <summary>
        /// 台本id
        /// </summary>
        [XmlElement("playscript_id")]
        public string PlayscriptId { get; set; }

        /// <summary>
        /// 台本名称
        /// </summary>
        [XmlElement("playscript_name")]
        public string PlayscriptName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// TEST_TENANT
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 台本类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 学员名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
