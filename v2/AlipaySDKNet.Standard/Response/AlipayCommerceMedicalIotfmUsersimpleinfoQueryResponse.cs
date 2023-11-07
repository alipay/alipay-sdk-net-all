using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIotfmUsersimpleinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIotfmUsersimpleinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 默认参保地市编码国标
        /// </summary>
        [XmlElement("fm_city_code")]
        public string FmCityCode { get; set; }

        /// <summary>
        /// 默认参保地市编码机构
        /// </summary>
        [XmlElement("fm_ins_city_code")]
        public string FmInsCityCode { get; set; }

        /// <summary>
        /// 参保地列表
        /// </summary>
        [XmlArray("fm_insu_city_list")]
        [XmlArrayItem("iot_fm_insu_city_v_o")]
        public List<IotFmInsuCityVO> FmInsuCityList { get; set; }

        /// <summary>
        /// 子账户用户openid
        /// </summary>
        [XmlElement("fm_open_id")]
        public string FmOpenId { get; set; }

        /// <summary>
        /// 子账户用户uid
        /// </summary>
        [XmlElement("fm_user_id")]
        public string FmUserId { get; set; }

        /// <summary>
        /// 子账户脱敏姓名
        /// </summary>
        [XmlElement("fm_user_name")]
        public string FmUserName { get; set; }
    }
}
