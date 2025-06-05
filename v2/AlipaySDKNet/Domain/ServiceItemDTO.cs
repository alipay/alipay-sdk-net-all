using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItemDTO : AopObject
    {
        /// <summary>
        /// 受理条件
        /// </summary>
        [XmlElement("accept_conditions")]
        public string AcceptConditions { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 事项办理的咨询电话
        /// </summary>
        [XmlElement("consult_tel")]
        public string ConsultTel { get; set; }

        /// <summary>
        /// 实施主体
        /// </summary>
        [XmlElement("implementation_subject")]
        public string ImplementationSubject { get; set; }

        /// <summary>
        /// 办理材料
        /// </summary>
        [XmlElement("material_list")]
        public string MaterialList { get; set; }

        /// <summary>
        /// 事项名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部事项id。必须保证唯一性。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 办理流程信息说明
        /// </summary>
        [XmlElement("process")]
        public string Process { get; set; }

        /// <summary>
        /// 事项办理地点说明
        /// </summary>
        [XmlElement("process_location")]
        public string ProcessLocation { get; set; }

        /// <summary>
        /// 事项办理的时间。时间单位一般具体到上午、下午、小时
        /// </summary>
        [XmlElement("process_time")]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 语料的运行状态
        /// </summary>
        [XmlElement("run_status")]
        public string RunStatus { get; set; }

        /// <summary>
        /// 事项服务的对象
        /// </summary>
        [XmlElement("service_object")]
        public string ServiceObject { get; set; }

        /// <summary>
        /// 法人事项主题
        /// </summary>
        [XmlElement("subject_juridical")]
        public string SubjectJuridical { get; set; }

        /// <summary>
        /// 个人事项主题
        /// </summary>
        [XmlElement("subject_nature")]
        public string SubjectNature { get; set; }

        /// <summary>
        /// 办事事项的跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
