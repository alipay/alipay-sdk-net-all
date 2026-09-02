using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageServicelauchCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageServicelauchCancelModel : AopObject
    {
        /// <summary>
        /// 主使用人手机号
        /// </summary>
        [XmlElement("main_user_phone_no")]
        public string MainUserPhoneNo { get; set; }

        /// <summary>
        /// 用户外部服务取消时间
        /// </summary>
        [XmlElement("out_cancel_time")]
        public string OutCancelTime { get; set; }

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
    }
}
