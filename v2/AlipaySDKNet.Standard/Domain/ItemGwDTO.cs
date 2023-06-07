using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemGwDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemGwDTO : AopObject
    {
        /// <summary>
        /// 该事项的办理需要前提的条件
        /// </summary>
        [XmlElement("accept_conditions")]
        public string AcceptConditions { get; set; }

        /// <summary>
        /// 事项所属云客服的类目，根目录下的一级或二级目录，美誉则创建
        /// </summary>
        [XmlArray("category")]
        [XmlArrayItem("string")]
        public List<string> Category { get; set; }

        /// <summary>
        /// 事项的材料清单
        /// </summary>
        [XmlArray("checklist")]
        [XmlArrayItem("string")]
        public List<string> Checklist { get; set; }

        /// <summary>
        /// 事项的唯一编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 事项联络详情（时间、地点、咨询方式）
        /// </summary>
        [XmlArray("contact")]
        [XmlArrayItem("item_contact_vo")]
        public List<ItemContactVo> Contact { get; set; }

        /// <summary>
        /// 国家统一区域编码
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 该事项实施的主体单位
        /// </summary>
        [XmlElement("implementation_subject")]
        public string ImplementationSubject { get; set; }

        /// <summary>
        /// 事项的小程序链接，alipays协议
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 事项的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支持： true；不支持：false。不填为false
        /// </summary>
        [XmlElement("online_support")]
        public bool OnlineSupport { get; set; }

        /// <summary>
        /// 支持：true；不支持：false。不填为false
        /// </summary>
        [XmlElement("palm_support")]
        public bool PalmSupport { get; set; }

        /// <summary>
        /// 支付宝小程序地址，alipays协议
        /// </summary>
        [XmlElement("palm_url")]
        public string PalmUrl { get; set; }

        /// <summary>
        /// 该事项关联的支付宝服务
        /// </summary>
        [XmlElement("rel_service")]
        public string RelService { get; set; }

        /// <summary>
        /// 政府标准事项
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 该事项服务的对象
        /// </summary>
        [XmlElement("service_object")]
        public string ServiceObject { get; set; }

        /// <summary>
        /// 事项主题（法人）
        /// </summary>
        [XmlArray("subject_juridical")]
        [XmlArrayItem("string")]
        public List<string> SubjectJuridical { get; set; }

        /// <summary>
        /// 事项主题（自然人）
        /// </summary>
        [XmlArray("subject_nature")]
        [XmlArrayItem("string")]
        public List<string> SubjectNature { get; set; }

        /// <summary>
        /// 该事项办理的流程
        /// </summary>
        [XmlElement("working_schedule")]
        public string WorkingSchedule { get; set; }
    }
}
