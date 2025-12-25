using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserequityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmUserequityQueryModel : AopObject
    {
        /// <summary>
        /// 基础权益编码
        /// </summary>
        [XmlElement("equity_basics_code")]
        public string EquityBasicsCode { get; set; }

        /// <summary>
        /// 权益包编码
        /// </summary>
        [XmlElement("equity_package_code")]
        public string EquityPackageCode { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("out_biz_serial_no")]
        public string OutBizSerialNo { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 项目标识
        /// </summary>
        [XmlElement("project_tag")]
        public string ProjectTag { get; set; }

        /// <summary>
        /// 健管用户ID（UID）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
