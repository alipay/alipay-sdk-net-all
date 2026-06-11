using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalYpzRecommendcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalYpzRecommendcardQueryModel : AopObject
    {
        /// <summary>
        /// 就医数据唯一ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 卡片编码
        /// </summary>
        [XmlElement("card_code")]
        public string CardCode { get; set; }

        /// <summary>
        /// 渠道信息
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 投放场景
        /// </summary>
        [XmlElement("delivery_scene")]
        public string DeliveryScene { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 平台openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构ID（医院）
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称（医院）
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 投放渠道
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 是否本人就医
        /// </summary>
        [XmlElement("self")]
        public bool Self { get; set; }

        /// <summary>
        /// 卡片状态编码
        /// </summary>
        [XmlElement("status_card_code")]
        public string StatusCardCode { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("table_type")]
        public string TableType { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 用户UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
