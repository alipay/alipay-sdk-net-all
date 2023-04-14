using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeexperimentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeexperimentQueryModel : AopObject
    {
        /// <summary>
        /// 查询实验数据的结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 查询实验数据的开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
