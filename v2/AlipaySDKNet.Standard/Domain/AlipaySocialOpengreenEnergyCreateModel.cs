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
        /// 用户进行绿色行为的时间，毫秒值，如果不传，默认为调用接口的时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 随机业务值，业务唯一单号，用户每一次绿色行为的唯一标识，幂等使用，最好32位，最长不能超过64位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展字符串，用于承接业务方的一些特殊字段，也用于承接一些特殊绿色场景所需传递的特殊字符串，比如缴费场景需要传入户号信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 二级场景类目， 用于描述用户的绿色行为以及对应的业务值
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
