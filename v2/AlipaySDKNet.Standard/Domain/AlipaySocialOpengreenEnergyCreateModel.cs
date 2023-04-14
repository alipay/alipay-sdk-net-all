using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialOpengreenEnergyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialOpengreenEnergyCreateModel : AopObject
    {
        /// <summary>
        /// 当前时间毫秒值
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 随机数，每个用户不唯一
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 二级场景类目
        /// </summary>
        [XmlElement("green_actions")]
        public string GreenActions { get; set; }

        /// <summary>
        /// 商户在支付宝申请的商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 请求场景码，业务方定义
        /// </summary>
        [XmlElement("request_scene_code")]
        public string RequestSceneCode { get; set; }

        /// <summary>
        /// 固定值，固定写openapi
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
