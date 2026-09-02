using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageServicelauchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageServicelauchCreateModel : AopObject
    {
        /// <summary>
        /// 主使用人信息
        /// </summary>
        [XmlElement("main_user_info")]
        public MainUserInfo MainUserInfo { get; set; }

        /// <summary>
        /// 用户外部服务支付时间
        /// </summary>
        [XmlElement("out_pay_time")]
        public string OutPayTime { get; set; }

        /// <summary>
        /// 外部业务唯一单号
        /// </summary>
        [XmlElement("out_unique_biz_no")]
        public string OutUniqueBizNo { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sub_user_info_list")]
        [XmlArrayItem("main_user_info")]
        public List<MainUserInfo> SubUserInfoList { get; set; }

        /// <summary>
        /// 外部服务失效时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 外部服务生效时间
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
