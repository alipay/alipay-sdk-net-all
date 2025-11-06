using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserskipQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmUserskipQueryModel : AopObject
    {
        /// <summary>
        /// 请求来源, H5, APP, WX_MINI_PROGRAM 微信小程序
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 权益编码, 下发权益时获取
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 权益包编码, 下发权益时获取
        /// </summary>
        [XmlElement("equity_package_code")]
        public string EquityPackageCode { get; set; }

        /// <summary>
        /// 健管人员id, 权益下发时发放给保司
        /// </summary>
        [XmlElement("hmuid")]
        public string Hmuid { get; set; }

        /// <summary>
        /// 业务唯一流水号, 需要确保当前保司下唯一
        /// </summary>
        [XmlElement("out_biz_serial_no")]
        public string OutBizSerialNo { get; set; }

        /// <summary>
        /// 权益所属项目标识, 下发权益时获取
        /// </summary>
        [XmlElement("project_tag")]
        public string ProjectTag { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("tel_no")]
        public string TelNo { get; set; }
    }
}
