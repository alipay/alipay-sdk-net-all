using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNuserWecomSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNuserWecomSyncModel : AopObject
    {
        /// <summary>
        /// { "state":生成二维码时传的token, "followUserId":用户加的企微id, "externalUserId":用户微信号密文id, "name":客户微信昵称, "type":--1-个人微信用户，2-企业微信用户, "avatar":客户头像链接, "gender":0-未知，1-男性，2-女性 "remark":该企微员工对客户的备注, "description":该企微员工对客户的描述, "addWay":1-(客户)扫码，2-(企微员工)搜索手机号, "phoneNo":客户手机号,  }
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// envId
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("event_timestamp")]
        public long EventTimestamp { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("im_app_id")]
        public string ImAppId { get; set; }

        /// <summary>
        /// source
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// tntInst_id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// type
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
