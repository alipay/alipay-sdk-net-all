using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserequitySyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmUserequitySyncResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("equity_info_list")]
        [XmlArrayItem("hm_equity_info")]
        public List<HmEquityInfo> EquityInfoList { get; set; }

        /// <summary>
        /// 权益下发场景必填，支付宝后台生成后给出固定编码值
        /// </summary>
        [XmlElement("equity_package_code")]
        public string EquityPackageCode { get; set; }

        /// <summary>
        /// 标识唯一一次权益下发
        /// </summary>
        [XmlElement("out_biz_serial_no")]
        public string OutBizSerialNo { get; set; }

        /// <summary>
        /// 约定合作项目标识，支付宝后台生成后给出固定编码值
        /// </summary>
        [XmlElement("project_tag")]
        public string ProjectTag { get; set; }

        /// <summary>
        /// 健管系统用户唯一标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
