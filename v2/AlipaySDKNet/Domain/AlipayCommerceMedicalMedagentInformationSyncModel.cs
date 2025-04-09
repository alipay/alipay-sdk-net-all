using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentInformationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentInformationSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝2088id
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// String 合作方dataId，重复调用dataId已存在会更新数据
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据类型，枚举基于双方业务约定 USER_INFO（用户信息），病程概要,SCALE（量表）,PIC（图片），治疗计划，
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 蚂蚁侧医生id，线下提供映射即可
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
