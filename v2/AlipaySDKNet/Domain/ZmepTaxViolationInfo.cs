using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepTaxViolationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepTaxViolationInfo : AopObject
    {
        /// <summary>
        /// 案件性质
        /// </summary>
        [XmlElement("ajxz")]
        public string Ajxz { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 纳税人识别码
        /// </summary>
        [XmlElement("nsr_cert_no")]
        public string NsrCertNo { get; set; }

        /// <summary>
        /// 纳税人名称
        /// </summary>
        [XmlElement("nsr_name")]
        public string NsrName { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 相关法律依据及税务处理处罚情况
        /// </summary>
        [XmlElement("xgflyjjswclcfqk")]
        public string Xgflyjjswclcfqk { get; set; }

        /// <summary>
        /// 主要违法事实
        /// </summary>
        [XmlElement("zywfss")]
        public string Zywfss { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("zzjg_code")]
        public string ZzjgCode { get; set; }
    }
}
