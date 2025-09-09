using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpManagerVO Data Structure.
    /// </summary>
    [Serializable]
    public class CorpManagerVO : AopObject
    {
        /// <summary>
        /// 委任日期
        /// </summary>
        [XmlElement("appoint_dt")]
        public string AppointDt { get; set; }

        /// <summary>
        /// 董监高姓名
        /// </summary>
        [XmlElement("manager_name")]
        public string ManagerName { get; set; }

        /// <summary>
        /// 董监高姓名(英文)
        /// </summary>
        [XmlElement("manager_name_en")]
        public string ManagerNameEn { get; set; }

        /// <summary>
        /// 职位代码
        /// </summary>
        [XmlElement("position_tp_code")]
        public string PositionTpCode { get; set; }

        /// <summary>
        /// 离任日期
        /// </summary>
        [XmlElement("resignation_dt")]
        public string ResignationDt { get; set; }
    }
}
